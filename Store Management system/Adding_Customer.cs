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
    public partial class Adding_Customer : Form
    {
        public Adding_Customer()
        {
            InitializeComponent();
        }

        private void Adding_Customer_Load(object sender, EventArgs e)
        {
            //I want the current_date text box filled with current date and time 
            //when we open ADding Cusomer load 
            //add the current date and time to the current_date text box
            current_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            current_date.ReadOnly = true; // Make it read-only if you don't want to allow editing
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_name_TextChanged(object sender, EventArgs e)
        {
            //add the name of customer to database customer table
            string customerName = customer_name.Text.Trim();
            // Check if the customer name is not empty

        }

        private void create_new_customer_Click(object sender, EventArgs e)
        {

            //When click this button Customer name, contact number, address with current date should be store in customer table with unique customer id
            string customerName = customer_name.Text.Trim();
            string contactNumber = contact_number.Text.Trim();
            string address = customer_address.Text.Trim();
            DateTime currentDate = DateTime.Now;
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // Assuming you have a method to insert the customer into the database
            try
            {
                using (SqlConnection con = new SqlConnection(DbHelper.GetConnectionString()))
                {
                    con.Open();
                    string query = "INSERT INTO customers (name, phone, address) VALUES (@name, @contact, @address)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName);
                        cmd.Parameters.AddWithValue("@contact", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);
                        //cmd.Parameters.AddWithValue("@createdAt", currentDate);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully.");

                            // Close the form after adding the customer
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ViewExistingCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_list customerList = new customer_list();
            customerList.Show();
        }
    }
}
