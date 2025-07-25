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
    public partial class Payments : Form
    {
        string connectionString = DbHelper.GetConnectionString();        public Payments()
        {
            InitializeComponent();
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

        private void Payments_Load(object sender, EventArgs e)
        {
            SetupAutoComplete(customerComboBox as ComboBox, "customers");
        }

        private void PaidButton_Click(object sender, EventArgs e)
        {
            if (agreecheck.Checked == false)
            {
                MessageBox.Show("Please agree to deducte the amount");
                return;
            }
            string customerName = customerComboBox.Text.Trim();
            string amountPaidText = amountPaidtextbox.Text.Trim();
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(amountPaidText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!decimal.TryParse(amountPaidText, out decimal amountPaid) || amountPaid <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // 1. Get customer_id from name
                    SqlCommand getCustomerIdCmd = new SqlCommand("SELECT customer_id FROM customers WHERE name = @name", con);
                    getCustomerIdCmd.Parameters.AddWithValue("@name", customerName);
                    object result = getCustomerIdCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Customer not found. Please check the name and try again.");
                        return;
                    } // customer not found
                    int customerId = Convert.ToInt32(result);
                    // 2. Insert payment record
                    string insertPaymentQuery = "INSERT INTO payments (customer_id, amount, payment_date) VALUES (@custId, @amountPaid, @paymentDate)";
                    SqlCommand insertPaymentCmd = new SqlCommand(insertPaymentQuery, con);
                    insertPaymentCmd.Parameters.AddWithValue("@custId", customerId);
                    insertPaymentCmd.Parameters.AddWithValue("@amountPaid", amountPaid);
                    insertPaymentCmd.Parameters.AddWithValue("@paymentDate", DateTime.Now);
                    int rowsAffected = insertPaymentCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment recorded successfully.");
                        amountPaidtextbox.Clear();
                        customerComboBox.SelectedIndex = -1; // Clear selection
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the payment: " + ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}