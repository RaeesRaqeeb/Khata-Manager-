using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Use OracleClient or ODP.NET if Oracle
namespace Store_Management_system
{
    public partial class Add_Khatah : Form
    {
        string connectionString = DbHelper.GetConnectionString();
        private DataTable customersDt = new DataTable();
        private DataTable itemsDt = new DataTable();
        public Add_Khatah()
        {
            InitializeComponent();
            unitPriceTextBox.ReadOnly = true;
            //customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Add_Khatah_Load(object sender, EventArgs e)
        {

            SetupDataGridView();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitprice_TextChanged(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string itemName = itemComboBox.Text.Trim();

            // Step 1: Lookup item_id and unit_price
            int itemId = -1;
            decimal unitPrice = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT item_id, unit_price FROM items WHERE name = @name", conn);
                cmd.Parameters.AddWithValue("@name", itemName);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    itemId = reader.GetInt32(0);
                    unitPrice = reader.GetDecimal(1);
                }
                else
                {
                    MessageBox.Show("Item not found in the database.");
                    return;
                }
            }

            // Step 2: Get quantity and calculate total
            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            decimal total = quantity * unitPrice;

            // Step 3: Add to DataGridView
            itemsDataGridView.Rows.Add(itemId, itemName, quantity, unitPrice, total);

            // Clear input
            itemComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string selectedName = customerComboBox.Text.Trim();
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            int customerId = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Get customer_id
                SqlCommand cmd = new SqlCommand("SELECT customer_id FROM customers WHERE name = @name", con);
                cmd.Parameters.AddWithValue("@name", selectedName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                // Insert purchases
                foreach (DataGridViewRow row in itemsDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                    string itemName = row.Cells["ItemName"].Value.ToString();
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    string insertPurchase = @"
                INSERT INTO purchases (customer_id, item_name_at_purchase, price_at_purchase, quantity)
                VALUES (@custId, @itemName, @price, @qty)";

                    SqlCommand purchaseCmd = new SqlCommand(insertPurchase, con);
                    purchaseCmd.Parameters.AddWithValue("@custId", customerId);
                    purchaseCmd.Parameters.AddWithValue("@itemName", itemName);
                    purchaseCmd.Parameters.AddWithValue("@price", unitPrice);
                    purchaseCmd.Parameters.AddWithValue("@qty", quantity);

                    purchaseCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Purchases recorded successfully.");
                itemsDataGridView.Rows.Clear();
            }
        }

        //        private void saveButton_Click(object sender, EventArgs e)
        //        {
        //            //int customerId = Convert.ToInt32(customerComboBox.SelectedValue);
        //            DateTime saleDate = DateTime.Now;
        //            string selectedName = customerComboBox.Text.Trim();

        //            if (string.IsNullOrEmpty(selectedName))
        //            {
        //                MessageBox.Show("Please select a customer.");
        //                return;
        //            }

        //            int customerId = -1;

        //            using (SqlConnection con = new SqlConnection(connectionString))
        //            {
        //                con.Open();
        //                SqlCommand cmd = new SqlCommand("SELECT customer_id FROM customers WHERE name = @name", con);
        //                cmd.Parameters.AddWithValue("@name", selectedName);

        //                object result = cmd.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    customerId = Convert.ToInt32(result);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Customer not found.");
        //                    return;
        //                }
        //                // Insert into sales
        //                string insertSale = "INSERT INTO sales (customer_id, sale_date, is_credit) OUTPUT INSERTED.sale_id VALUES (@custId, @date, 1)";
        //                SqlCommand cmd2 = new SqlCommand(insertSale, con);
        //                cmd2.Parameters.AddWithValue("@custId", customerId);
        //                cmd2.Parameters.AddWithValue("@date", saleDate);
        //                int saleId = (int)cmd2.ExecuteScalar();

        //                // Insert each item into sale_items
        //                foreach (DataGridViewRow row in itemsDataGridView.Rows)
        //                {
        //                    if (row.IsNewRow) continue;

        //                    int itemId = Convert.ToInt32(row.Cells[0].Value);
        //                    decimal price = Convert.ToDecimal(row.Cells[2].Value);
        //                    int qty = Convert.ToInt32(row.Cells[3].Value);

        //                    string insertItem = "INSERT INTO sale_items (sale_id, item_id, price_per_item, quantity) VALUES (@saleId, @itemId, @price, @qty)";
        //                    SqlCommand itemCmd = new SqlCommand(insertItem, con);
        //                    itemCmd.Parameters.AddWithValue("@saleId", saleId);
        //                    itemCmd.Parameters.AddWithValue("@itemId", itemId);
        //                    itemCmd.Parameters.AddWithValue("@price", price);
        //                    itemCmd.Parameters.AddWithValue("@qty", qty);

        //                    itemCmd.ExecuteNonQuery();
        //                }

        //                // After inserting, calculate total credit taken by the customer that day
        //                // Calculate total for this sale
        //                string totalForThisSaleQuery = @"
        //SELECT SUM(quantity * price_per_item) 
        //FROM sale_items 
        //WHERE sale_id = @saleId";

        //                SqlCommand totalSaleCmd = new SqlCommand(totalForThisSaleQuery, con);
        //                totalSaleCmd.Parameters.AddWithValue("@saleId", saleId);

        //                object totalResult = totalSaleCmd.ExecuteScalar();
        //                decimal saleTotalAmount = totalResult != DBNull.Value ? Convert.ToDecimal(totalResult) : 0;

        //                // Update sales table with the total amount
        //                string updateSale = "UPDATE sales SET total_amount = @total WHERE sale_id = @saleId";
        //                SqlCommand updateCmd = new SqlCommand(updateSale, con);
        //                updateCmd.Parameters.AddWithValue("@total", saleTotalAmount);
        //                updateCmd.Parameters.AddWithValue("@saleId", saleId);

        //                updateCmd.ExecuteNonQuery();
        //                MessageBox.Show("Credit sale added successfully!");
        //                itemsDataGridView.Rows.Clear();
        //            }
        //        }



        private void SetupDataGridView()
        {
            itemsDataGridView.Columns.Clear();

            itemsDataGridView.Columns.Add("ItemId", "Item ID");
            itemsDataGridView.Columns["ItemId"].Visible = false;

            itemsDataGridView.Columns.Add("ItemName", "Item Name");
            itemsDataGridView.Columns.Add("UnitPrice", "Unit Price");
            itemsDataGridView.Columns.Add("Quantity", "Quantity");
            itemsDataGridView.Columns.Add("Total", "Total");
        }
        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        private void Add_Khatah_Load_1(object sender, EventArgs e)
        {
            SetupAutoComplete(customerComboBox, "customers");
            SetupAutoComplete(itemComboBox, "items");
        }

        private void previous_window_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}

