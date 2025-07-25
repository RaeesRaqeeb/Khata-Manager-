namespace Store_Management_system
{
    partial class viewKhatahistory
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
            monthly_record_save = new Button();
            save_excel = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            customerComboBox = new ComboBox();
            record_search = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 1;
            label1.Text = "Search the customer";
            // 
            // panel1
            // 
            panel1.Controls.Add(monthly_record_save);
            panel1.Controls.Add(save_excel);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 386);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // monthly_record_save
            // 
            monthly_record_save.Location = new Point(352, 358);
            monthly_record_save.Name = "monthly_record_save";
            monthly_record_save.Size = new Size(106, 23);
            monthly_record_save.TabIndex = 3;
            monthly_record_save.Text = "Save it in Excel";
            monthly_record_save.UseVisualStyleBackColor = true;
            monthly_record_save.Click += monthly_record_save_Click;
            // 
            // save_excel
            // 
            save_excel.Location = new Point(352, 175);
            save_excel.Name = "save_excel";
            save_excel.Size = new Size(106, 23);
            save_excel.TabIndex = 2;
            save_excel.Text = "Save it in Excel";
            save_excel.UseVisualStyleBackColor = true;
            save_excel.Click += save_excel_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 215);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(442, 137);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 153);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(146, 22);
            label2.Name = "label2";
            label2.Size = new Size(181, 37);
            label2.TabIndex = 3;
            label2.Text = "Khatah Book";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(207, 67);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(137, 23);
            customerComboBox.TabIndex = 11;
            // 
            // record_search
            // 
            record_search.Location = new Point(12, 12);
            record_search.Name = "record_search";
            record_search.Size = new Size(75, 23);
            record_search.TabIndex = 12;
            record_search.Text = "<- Back";
            record_search.UseVisualStyleBackColor = true;
            record_search.Click += back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(350, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewKhatahistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(493, 513);
            Controls.Add(button1);
            Controls.Add(record_search);
            Controls.Add(customerComboBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "viewKhatahistory";
            Text = "viewKhatahistory";
            Load += viewKhatahistory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox customerComboBox;
        private Button record_search;
        private Button button1;
        private Button save_excel;
        private Button monthly_record_save;
    }
}