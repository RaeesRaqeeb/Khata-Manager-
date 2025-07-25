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
    public partial class searchItem : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Freelancing\\New folder\\Store Management system\\Store Management system\\Database1.mdf\";Integrated Security=True";

        public searchItem()
        {
            InitializeComponent();
        }
        private void SetupAutoComplete(ComboBox comboBox, string tableName)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.GetConnectionString()))
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
        private void searchItem_Load(object sender, EventArgs e)
        {

            SetupAutoComplete(searchitemcombobox as ComboBox, "items");
            //adding items detail to datagridview

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item_name = searchitemcombobox.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT name, unit_price FROM items WHERE name = @item_name";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@item_name", item_name);

                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Use command here
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_items manage_Items = new Manage_items();
            manage_Items.Show();
        }
    }
}
