using Microsoft.Data.SqlClient; // Use OracleClient or ODP.NET if Oracle    
using DataTable = System.Data.DataTable; // Ensure you have the Microsoft.Office.Interop.Excel package installed
namespace Store_Management_system
{
    public partial class viewKhatahistory : Form
    {
        string connectionString = DbHelper.GetConnectionString();
        public viewKhatahistory()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetupAutoComplete(System.Windows.Forms.ComboBox comboBox, string tableName)
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
        private void viewKhatahistory_Load(object sender, EventArgs e)
        {
            SetupAutoComplete(customerComboBox, "customers");

        }

        private void customer_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string customerName = customerComboBox.Text.Trim();
            if (customerName.Length < 2) return;
            MessageBox.Show("Loading history for: " + customerName);

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
                    con.Close();
                    return;
                } // customer not found

                int customerId = Convert.ToInt32(result);

                // 2. Load item history
                //    string itemHistoryQuery = @"
                //SELECT 
                //    i.name AS [Item Name],
                //    si.quantity AS [Quantity],
                //    si.total_price AS [Amount],
                //    s.sale_date AS [Date Purchased]
                //FROM sale_items si
                //JOIN sales s ON s.sale_id = si.sale_id
                //JOIN items i ON i.item_id = si.item_id
                //WHERE s.customer_id = @custId
                //ORDER BY s.sale_date DESC;";
                string itemHistoryQuery = @"
SELECT 
    p.item_name_at_purchase AS [Item Name],
    p.quantity AS [Quantity],
    p.price_at_purchase * p.quantity AS [Amount],
    p.purchase_date AS [Date Purchased]
FROM purchases p
WHERE p.customer_id = @custId
ORDER BY p.purchase_date DESC;";

                SqlDataAdapter da = new SqlDataAdapter(itemHistoryQuery, con);
                da.SelectCommand.Parameters.AddWithValue("@custId", customerId);
                DataTable dtItems = new DataTable();
                da.Fill(dtItems);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dtItems;


                // 1. Get monthly totals
                Dictionary<string, decimal> monthlyTotals = new Dictionary<string, decimal>();
                //            SqlCommand monthTotalsCmd = new SqlCommand(@"
                //SELECT 
                //    FORMAT(s.sale_date, 'MMMM yyyy') AS [Month],
                //    SUM(si.total_price) AS [Total Amount]
                //FROM sale_items si
                //JOIN sales s ON si.sale_id = s.sale_id
                //WHERE s.customer_id = @custId
                //GROUP BY FORMAT(s.sale_date, 'MMMM yyyy')
                //ORDER BY MIN(s.sale_date);", con);
                SqlCommand monthTotalsCmd = new SqlCommand(@"
    SELECT 
        FORMAT(p.purchase_date, 'MMMM yyyy') AS [Month],
        SUM(p.quantity * p.price_at_purchase) AS [Total Amount]
    FROM purchases p
    WHERE p.customer_id = @custId
    GROUP BY FORMAT(p.purchase_date, 'MMMM yyyy')
    ORDER BY MIN(p.purchase_date);", con);

                monthTotalsCmd.Parameters.AddWithValue("@custId", customerId);
                SqlDataReader reader = monthTotalsCmd.ExecuteReader();
                while (reader.Read())
                {
                    string month = reader["Month"].ToString();
                    decimal total = Convert.ToDecimal(reader["Total Amount"]);
                    monthlyTotals[month] = total;
                }
                reader.Close();

                // 2. Get total payments
                List<decimal> payments = new List<decimal>();
                SqlCommand paymentsCmd = new SqlCommand("SELECT amount FROM payments WHERE customer_id = @custId ORDER BY payment_date;", con);
                paymentsCmd.Parameters.AddWithValue("@custId", customerId);
                SqlDataReader paymentReader = paymentsCmd.ExecuteReader();

                // 1. Load all payments
                while (paymentReader.Read())
                {
                    payments.Add(Convert.ToDecimal(paymentReader["amount"]));
                }
                paymentReader.Close();

                // 2. Prepare columns
                decimal remainingPayment = payments.Sum();
                DataTable dtInstallments = new DataTable();
                dtInstallments.Columns.Add("Month");
                dtInstallments.Columns.Add("Total Amount", typeof(decimal));
                dtInstallments.Columns.Add("Paid", typeof(decimal));
                dtInstallments.Columns.Add("Remaining Amount", typeof(decimal));

                // 3. Distribute payments over monthly totals
                foreach (var kvp in monthlyTotals)
                {
                    string month = kvp.Key;
                    decimal total = kvp.Value;
                    decimal paid = 0;

                    if (remainingPayment > 0)
                    {
                        paid = Math.Min(total, remainingPayment);
                        remainingPayment -= paid;
                    }

                    decimal remaining = total - paid;

                    // 4. Add row for this month
                    dtInstallments.Rows.Add(month, total, paid, remaining);
                }

                // 5. Bind to DataGridView
                dataGridView2.DataSource = dtInstallments;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ExportToCsv(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV file (*.csv)|*.csv",
                FileName = "Export.csv"
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
        private void monthly_record_save_Click(object sender, EventArgs e)
        {
            ExportToCsv(dataGridView2);
        }

        private void save_excel_Click(object sender, EventArgs e)
        {
            ExportToCsv(dataGridView1);

        }
    }

    
}
