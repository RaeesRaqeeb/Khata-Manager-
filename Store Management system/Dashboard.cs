using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Khatah addCustomerForm = new Add_Khatah();
            addCustomerForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void manageCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_Customer manageCustomerForm = new Adding_Customer();
            manageCustomerForm.Show();
        }

        private void adding_items_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_items manageItemsForm = new Manage_items();
            manageItemsForm.Show();
        }

        private void KhataHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewKhatahistory khataHistoryForm = new viewKhatahistory();
            khataHistoryForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //end the application
            Application.Exit();
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments paymentsForm = new Payments();
            paymentsForm.Show();
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletingRecords deletingRecordsForm = new DeletingRecords();
            deletingRecordsForm.Show();
        }
    }
}
