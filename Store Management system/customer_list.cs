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
    public partial class customer_list : Form
    {
        public customer_list()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void customer_list_Load(object sender, EventArgs e)
        {
            // Set this property in the designer or here
            dataGridView1.AutoGenerateColumns = true;

            string connectionString = DbHelper.GetConnectionString();            // Use a try-catch block to catch any potential errors
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // The query can be simplified and made more robust
                    //                    string query = @"
                    //               SELECT 
                    //    c.name AS [Name],
                    //    c.phone AS [Number],
                    //    FORMAT(c.joined_date, 'yyyy-MM-dd') AS [Date],
                    //    ISNULL(s.total_credit, 0) - ISNULL(p.total_paid, 0) AS [Total Due]
                    //FROM 
                    //    customers c
                    //LEFT JOIN 
                    //    (
                    //        SELECT customer_id, SUM(total_amount) AS total_credit
                    //        FROM sales
                    //        WHERE is_credit = 1
                    //        GROUP BY customer_id
                    //    ) s ON c.customer_id = s.customer_id
                    //LEFT JOIN 
                    //    (
                    //        SELECT customer_id, SUM(amount) AS total_paid
                    //        FROM payments
                    //        GROUP BY customer_id
                    //    ) p ON c.customer_id = p.customer_id
                    //ORDER BY 
                    //    c.name;
                    //"; // Optional: sort the results
                    string query = @"
SELECT 
    c.name AS [Name],
    c.phone AS [Number],
    FORMAT(c.joined_date, 'yyyy-MM-dd') AS [Date],
    ISNULL(purchases.total_credit, 0) - ISNULL(payments.total_paid, 0) AS [Total Due]
FROM 
    customers c
LEFT JOIN 
    (
        SELECT customer_id, SUM(quantity * price_at_purchase) AS total_credit
        FROM purchases
        GROUP BY customer_id
    ) purchases ON c.customer_id = purchases.customer_id
LEFT JOIN 
    (
        SELECT customer_id, SUM(amount) AS total_paid
        FROM payments
        GROUP BY customer_id
    ) payments ON c.customer_id = payments.customer_id
ORDER BY 
    c.name;
";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // If an error occurs, display it in a message box
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_Customer adding_Customer = new Adding_Customer();
            adding_Customer.Show();
        }
        private void ExportToCsv(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV file (*.csv)|*.csv",
                FileName = "Customer Record.csv"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            sw.Write(dgv.Columns[i].HeaderText);
                            if (i < dgv.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgv.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dgv.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Data exported to CSV successfully!");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            ExportToCsv(dataGridView1);
        }
    }
}
