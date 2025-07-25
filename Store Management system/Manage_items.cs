using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_system
{
    public partial class Manage_items : Form
    {
        string connectionString = DbHelper.GetConnectionString();
        public Manage_items()
        {
            InitializeComponent();
        }


        private void Manage_items_Load(object sender, EventArgs e)
        {

            //adding items detail to datagridview
            try
            {
                itemsDataGridView.AutoGenerateColumns = true;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"select * from items;";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    itemsDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchItem item = new searchItem();
            item.Show();

        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item_name = this.itemnamebox.Text;
            string unit_price = this.Unitpricebox.Text;
            int unit = Convert.ToInt32(unit_price);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Raqeeb\\source\\repos\\Store Management system\\Store Management system\\Database1.mdf\";Integrated Security=True"))
                {
                    con.Open();
                    string query = "INSERT INTO items (name, unit_price) VALUES (@name, @unit)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", item_name);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully.");

                            // Close the form after adding the customer
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Delete_items_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_item edit = new Edit_item();
            edit.Show();
        }
    }
}
