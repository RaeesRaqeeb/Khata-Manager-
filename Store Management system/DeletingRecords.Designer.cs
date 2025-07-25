namespace Store_Management_system
{
    partial class DeletingRecords
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
            button1 = new Button();
            customerComboBox = new ComboBox();
            label1 = new Label();
            back = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 89);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
            button1.TabIndex = 0;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(72, 89);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(137, 23);
            customerComboBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(53, 39);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 12;
            label1.Text = "Deleting Records";
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            back.Location = new Point(12, 22);
            back.Name = "back";
            back.Size = new Size(58, 23);
            back.TabIndex = 13;
            back.Text = "<- Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // DeletingRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(321, 134);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(customerComboBox);
            Controls.Add(button1);
            Name = "DeletingRecords";
            Text = "DeletingRecords";
            Load += DeletingRecords_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox customerComboBox;
        private Label label1;
        private Button back;
    }
}