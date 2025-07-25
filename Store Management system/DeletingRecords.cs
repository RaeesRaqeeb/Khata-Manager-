using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Store_Management_system
{
    public partial class DeletingRecords : Form
    {
        string connectionString = DbHelper.GetConnectionString();
        public DeletingRecords()
        {
            InitializeComponent();
        }

        private void DeletingRecords_Load(object sender, EventArgs e)
        {
            SetupAutoComplete(customerComboBox as ComboBox, "customers");
        }
        private void SetupAutoComplete(ComboBox comboBox, string tableName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT name FROM {tableName}", con);
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
                comboBox.Items.Clear();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    comboBox.Items.Add(name);
                    autoSource.Add(name);
                }
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                comboBox.AutoCompleteCustomSource = autoSource;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCustomerName = customerComboBox.Text;

            if (string.IsNullOrWhiteSpace(selectedCustomerName))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete all data of '{selectedCustomerName}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        // Get customer_id from name
                        SqlCommand getIdCmd = new SqlCommand("SELECT customer_id FROM customers WHERE name = @name", con, transaction);
                        getIdCmd.Parameters.AddWithValue("@name", selectedCustomerName);
                        object customerIdObj = getIdCmd.ExecuteScalar();

                        if (customerIdObj == null)
                        {
                            MessageBox.Show("Customer not found.");
                            return;
                        }

                        int customerId = Convert.ToInt32(customerIdObj);

                        // 1. Delete sale_items
                        SqlCommand deleteSaleItems = new SqlCommand(@"
                    DELETE FROM sale_items 
                    WHERE sale_id IN (SELECT sale_id FROM sales WHERE customer_id = @cid)", con, transaction);
                        deleteSaleItems.Parameters.AddWithValue("@cid", customerId);
                        deleteSaleItems.ExecuteNonQuery();

                        // 2. Delete sales
                        SqlCommand deleteSales = new SqlCommand("DELETE FROM sales WHERE customer_id = @cid", con, transaction);
                        deleteSales.Parameters.AddWithValue("@cid", customerId);
                        deleteSales.ExecuteNonQuery();


                        // Step 1: Get total purchased amount for the customer
                        SqlCommand totalPurchasedCmd = new SqlCommand(
                            "SELECT ISNULL(SUM(total_amount), 0) FROM purchases WHERE customer_id = @cid",
                            con, transaction);
                        totalPurchasedCmd.Parameters.AddWithValue("@cid", customerId);
                        decimal totalPurchased = Convert.ToDecimal(totalPurchasedCmd.ExecuteScalar());

                        // Step 2: Get total paid amount for the customer
                        SqlCommand totalPaidCmd = new SqlCommand(
                            "SELECT ISNULL(SUM(amount), 0) FROM payments WHERE customer_id = @cid",
                            con, transaction);
                        totalPaidCmd.Parameters.AddWithValue("@cid", customerId);
                        decimal totalPaid = Convert.ToDecimal(totalPaidCmd.ExecuteScalar());

                        // Step 3: Check if dues are cleared (paid - purchased == 0)
                        if (totalPaid < totalPurchased)
                        {
                            MessageBox.Show("Customer cannot be deleted because there are pending dues.");
                            transaction.Rollback();
                            return;
                        }

                        // Step 4: Safe to delete related records
                        // Delete from purchased table
                        SqlCommand deletePurchases = new SqlCommand(
                            "DELETE FROM purchases WHERE customer_id = @cid",
                            con, transaction);
                        deletePurchases.Parameters.AddWithValue("@cid", customerId);
                        deletePurchases.ExecuteNonQuery();

                        // You can proceed to delete from payments, sales, etc., and finally delete the customer

                        // 3. Delete payments
                        SqlCommand deletePayments = new SqlCommand("DELETE FROM payments WHERE customer_id = @cid", con, transaction);
                        deletePayments.Parameters.AddWithValue("@cid", customerId);
                        deletePayments.ExecuteNonQuery();

                        // 4. Delete customer
                        SqlCommand deleteCustomer = new SqlCommand("DELETE FROM customers WHERE customer_id = @cid", con, transaction);
                        deleteCustomer.Parameters.AddWithValue("@cid", customerId);
                        deleteCustomer.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Customer and all related data deleted successfully.");
                        SetupAutoComplete(customerComboBox as ComboBox, "customers"); // refresh combo box
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to delete records: " + ex.Message);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
