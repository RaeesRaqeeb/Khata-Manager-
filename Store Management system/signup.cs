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
using System.Windows.Forms;

namespace Store_Management_system
{
    public partial class signup : Form
    {
       
            private Label labelMessage;
            public signup()
            {
                InitializeComponent();
                // Initialize labelMessage if not done in designer
                labelMessage = new Label
                {
                    Name = "labelMessage",
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, 120) // Adjust location as needed
                };
                this.Controls.Add(labelMessage);

            }

            private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void username_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text.Trim();
            string password = password_input.Text.Trim();

            if (username == "" || password == "")
            {
                labelMessage.Text = "Username or password cannot be empty.";
                return;
            }

            try
            {
                // Replace with your actual connection string
                string connString = DbHelper.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Check if user already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        labelMessage.Text = "Username already exists.";
                        return;
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password); // 🔐 Hash in real app

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show( "Signup successful!");
                        
                        username_input.Text = "";
                        password_input.Text = "";
                        this.Hide();
                        login loginForm = new login();
                        loginForm.Show();
                    }
                    else
                    {
                        labelMessage.Text = "Signup failed. Try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}


