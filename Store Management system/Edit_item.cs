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
    public partial class Edit_item : Form
    {
        string connectionString = DbHelper.GetConnectionString();
        public Edit_item()
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

        private void deletingItems_Load(object sender, EventArgs e)
        {
            SetupAutoComplete(itemComboBox, "items");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_items manage_Items = new Manage_items();
            manage_Items.Show();
        }

        private void delete_item_Click(object sender, EventArgs e)
        {
            string itemNameToDelete = itemComboBox.Text.Trim();

            if (string.IsNullOrEmpty(itemNameToDelete))
            {
                MessageBox.Show("Please select an item to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete '{itemNameToDelete}' from the inventory?\nPurchased records will remain unchanged.",
                                                          "Confirm Delete",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM items WHERE name = @name";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", itemNameToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetupAutoComplete(itemComboBox, "items"); // Refresh item list
                            itemComboBox.Text = ""; // Clear selection
                        }
                        else
                        {
                            MessageBox.Show("Item not found or already deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editing_item_info_Click(object sender, EventArgs e)
        {
            //ask for new price and new name in pop up



            string oldName = itemComboBox.Text.Trim();         // You should have a control named Old_name
            string newName = new_name.Text.Trim();
            string newPriceText = new_price.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPriceText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(newPriceText, out decimal newPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE items SET name = @newName, unit_price = @newPrice where name=@oldname ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@newPrice", newPrice);
                    cmd.Parameters.AddWithValue("@oldname", oldName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_name.Text = new_price.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void itemComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
