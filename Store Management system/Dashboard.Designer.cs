namespace Store_Management_system
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            Payments = new Button();
            adding_items = new Button();
            manageCustomer = new Button();
            button6 = new Button();
            KhataHistory = new Button();
            Add_khatah = new Button();
            deleteRecord = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.TabIndex = 0;
            label1.Text = "Khata Management System";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Payments);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(adding_items);
            panel1.Controls.Add(manageCustomer);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(KhataHistory);
            panel1.Controls.Add(Add_khatah);
            panel1.Location = new Point(53, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 371);
            panel1.TabIndex = 1;
            // 
            // Payments
            // 
            Payments.Font = new Font("Segoe UI", 10F);
            Payments.Location = new Point(16, 281);
            Payments.Name = "Payments";
            Payments.Size = new Size(187, 51);
            Payments.TabIndex = 8;
            Payments.Text = "Payments";
            Payments.UseVisualStyleBackColor = true;
            Payments.Click += Payments_Click;
            // 
            // adding_items
            // 
            adding_items.BackColor = SystemColors.ButtonFace;
            adding_items.Font = new Font("Segoe UI", 10F);
            adding_items.Location = new Point(248, 190);
            adding_items.Name = "adding_items";
            adding_items.Size = new Size(187, 49);
            adding_items.TabIndex = 7;
            adding_items.Text = "Adding Items";
            adding_items.UseVisualStyleBackColor = false;
            adding_items.Click += adding_items_Click;
            // 
            // manageCustomer
            // 
            manageCustomer.BackColor = SystemColors.ButtonFace;
            manageCustomer.Font = new Font("Segoe UI", 10F);
            manageCustomer.Location = new Point(16, 190);
            manageCustomer.Name = "manageCustomer";
            manageCustomer.Size = new Size(187, 49);
            manageCustomer.TabIndex = 6;
            manageCustomer.Text = "Manage Customers";
            manageCustomer.UseVisualStyleBackColor = false;
            manageCustomer.Click += manageCustomer_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI", 10F);
            button6.Location = new Point(248, 284);
            button6.Name = "button6";
            button6.Size = new Size(187, 48);
            button6.TabIndex = 5;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // KhataHistory
            // 
            KhataHistory.BackColor = SystemColors.ButtonFace;
            KhataHistory.Font = new Font("Segoe UI", 10F);
            KhataHistory.Location = new Point(248, 93);
            KhataHistory.Name = "KhataHistory";
            KhataHistory.Size = new Size(187, 49);
            KhataHistory.TabIndex = 1;
            KhataHistory.Text = "View Khatah history";
            KhataHistory.UseVisualStyleBackColor = false;
            KhataHistory.Click += KhataHistory_Click;
            // 
            // Add_khatah
            // 
            Add_khatah.BackColor = SystemColors.ButtonFace;
            Add_khatah.Font = new Font("Segoe UI", 10F);
            Add_khatah.Location = new Point(16, 93);
            Add_khatah.Name = "Add_khatah";
            Add_khatah.Size = new Size(187, 49);
            Add_khatah.TabIndex = 0;
            Add_khatah.Text = "Adding Khata";
            Add_khatah.UseVisualStyleBackColor = false;
            Add_khatah.Click += add_customer_Click;
            // 
            // deleteRecord
            // 
            deleteRecord.Location = new Point(24, 415);
            deleteRecord.Name = "deleteRecord";
            deleteRecord.Size = new Size(161, 23);
            deleteRecord.TabIndex = 2;
            deleteRecord.Text = "Delete Customer Records";
            deleteRecord.UseVisualStyleBackColor = true;
            deleteRecord.Click += deleteRecord_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 426);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Made By Raqeeb";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(567, 450);
            Controls.Add(label2);
            Controls.Add(deleteRecord);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button6;
        private Button KhataHistory;
        private Button Add_khatah;
        private Button manageCustomer;
        private Button adding_items;
        private Button Payments;
        private Button deleteRecord;
        private Label label2;
    }
}