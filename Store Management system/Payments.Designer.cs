namespace Store_Management_system
{
    partial class Payments
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
            customerComboBox = new ComboBox();
            name = new Label();
            label1 = new Label();
            amountPaidtextbox = new TextBox();
            agreecheck = new CheckBox();
            PaidButton = new Button();
            backbutton = new Button();
            SuspendLayout();
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(190, 54);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(137, 23);
            customerComboBox.TabIndex = 11;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 15F);
            name.Location = new Point(21, 49);
            name.Name = "name";
            name.Size = new Size(153, 28);
            name.TabIndex = 12;
            name.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 13;
            label1.Text = "Payment Amount";
            // 
            // amountPaidtextbox
            // 
            amountPaidtextbox.Location = new Point(190, 103);
            amountPaidtextbox.Name = "amountPaidtextbox";
            amountPaidtextbox.Size = new Size(137, 23);
            amountPaidtextbox.TabIndex = 14;
            // 
            // agreecheck
            // 
            agreecheck.AutoSize = true;
            agreecheck.Location = new Point(134, 149);
            agreecheck.Name = "agreecheck";
            agreecheck.Size = new Size(163, 19);
            agreecheck.TabIndex = 15;
            agreecheck.Text = "Amount will be deducted ";
            agreecheck.UseVisualStyleBackColor = true;
            agreecheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PaidButton
            // 
            PaidButton.Location = new Point(147, 186);
            PaidButton.Name = "PaidButton";
            PaidButton.Size = new Size(75, 23);
            PaidButton.TabIndex = 16;
            PaidButton.Text = "Paid";
            PaidButton.UseVisualStyleBackColor = true;
            PaidButton.Click += PaidButton_Click;
            // 
            // backbutton
            // 
            backbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            backbutton.Location = new Point(12, 12);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(75, 23);
            backbutton.TabIndex = 17;
            backbutton.Text = "<-Back";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(429, 238);
            Controls.Add(backbutton);
            Controls.Add(PaidButton);
            Controls.Add(agreecheck);
            Controls.Add(amountPaidtextbox);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(customerComboBox);
            Name = "Payments";
            Text = "Form1";
            Load += Payments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox customerComboBox;
        private Label name;
        private Label label1;
        private TextBox amountPaidtextbox;
        private CheckBox agreecheck;
        private Button PaidButton;
        private Button backbutton;
    }
}