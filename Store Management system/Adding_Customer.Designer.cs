namespace Store_Management_system
{
    partial class Adding_Customer
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
            label5 = new Label();
            ViewExistingCustomer = new Button();
            current_date = new TextBox();
            customer_address = new TextBox();
            contact_number = new TextBox();
            customer_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            create_new_customer = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(100, 46);
            label5.Name = "label5";
            label5.Size = new Size(215, 28);
            label5.TabIndex = 21;
            label5.Text = "Add the New Customer";
            // 
            // ViewExistingCustomer
            // 
            ViewExistingCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            ViewExistingCustomer.Location = new Point(31, 315);
            ViewExistingCustomer.Name = "ViewExistingCustomer";
            ViewExistingCustomer.Size = new Size(180, 23);
            ViewExistingCustomer.TabIndex = 20;
            ViewExistingCustomer.Text = "View the Existing Customer";
            ViewExistingCustomer.UseVisualStyleBackColor = true;
            ViewExistingCustomer.Click += ViewExistingCustomer_Click;
            // 
            // current_date
            // 
            current_date.Location = new Point(203, 222);
            current_date.Multiline = true;
            current_date.Name = "current_date";
            current_date.Size = new Size(172, 28);
            current_date.TabIndex = 19;
            // 
            // customer_address
            // 
            customer_address.Location = new Point(203, 179);
            customer_address.Multiline = true;
            customer_address.Name = "customer_address";
            customer_address.Size = new Size(172, 28);
            customer_address.TabIndex = 18;
            // 
            // contact_number
            // 
            contact_number.Location = new Point(203, 134);
            contact_number.Multiline = true;
            contact_number.Name = "contact_number";
            contact_number.Size = new Size(172, 28);
            contact_number.TabIndex = 17;
            // 
            // customer_name
            // 
            customer_name.Location = new Point(203, 92);
            customer_name.Multiline = true;
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(172, 28);
            customer_name.TabIndex = 16;
            customer_name.TextChanged += customer_name_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(31, 222);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 15;
            label4.Text = "Khatah Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(100, 179);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 14;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(25, 134);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 13;
            label2.Text = "Contact Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(31, 92);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 11;
            label1.Text = "Customer Name";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(12, 26);
            button3.Name = "button3";
            button3.Size = new Size(31, 23);
            button3.TabIndex = 22;
            button3.Text = "<--";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // create_new_customer
            // 
            create_new_customer.Location = new Point(224, 268);
            create_new_customer.Name = "create_new_customer";
            create_new_customer.Size = new Size(126, 23);
            create_new_customer.TabIndex = 23;
            create_new_customer.Text = "Adding Customer";
            create_new_customer.UseVisualStyleBackColor = true;
            create_new_customer.Click += create_new_customer_Click;
            // 
            // Adding_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(411, 382);
            Controls.Add(create_new_customer);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(ViewExistingCustomer);
            Controls.Add(current_date);
            Controls.Add(customer_address);
            Controls.Add(contact_number);
            Controls.Add(customer_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Adding_Customer";
            Text = "Adding_Customer";
            Load += Adding_Customer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label5;
        private Button ViewExistingCustomer;
        private TextBox current_date;
        private TextBox customer_address;
        private TextBox contact_number;
        private TextBox customer_name;
        private Label label4;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Button create_new_customer;
    }
}