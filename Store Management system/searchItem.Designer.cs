namespace Store_Management_system
{
    partial class searchItem
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
            dataGridView1 = new DataGridView();
            searchitemcombobox = new ComboBox();
            name = new Label();
            button1 = new Button();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(272, 53);
            dataGridView1.TabIndex = 0;
            // 
            // searchitemcombobox
            // 
            searchitemcombobox.FormattingEnabled = true;
            searchitemcombobox.Location = new Point(210, 46);
            searchitemcombobox.Name = "searchitemcombobox";
            searchitemcombobox.Size = new Size(154, 23);
            searchitemcombobox.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            name.Location = new Point(26, 41);
            name.Name = "name";
            name.Size = new Size(178, 28);
            name.TabIndex = 2;
            name.Text = "Enter Item Name:";
            // 
            // button1
            // 
            button1.Location = new Point(370, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            back.Location = new Point(12, 12);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 4;
            back.Text = "<- Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // searchItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(492, 198);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(name);
            Controls.Add(searchitemcombobox);
            Controls.Add(dataGridView1);
            Name = "searchItem";
            Text = "searchItem";
            Load += searchItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox searchitemcombobox;
        private Label name;
        private Button button1;
        private Button back;
    }
}