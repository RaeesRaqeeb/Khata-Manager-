namespace Store_Management_system
{
    partial class customer_list
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
            label1 = new Label();
            back = new Button();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 390);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer List";
            label1.Click += label1_Click;
            // 
            // back
            // 
            back.Location = new Point(12, 16);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 2;
            back.Text = "<- Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // save
            // 
            save.Location = new Point(360, 18);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 3;
            save.Text = "Save to file";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // customer_list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(save);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "customer_list";
            Text = "customer_list";
            Load += customer_list_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button back;
        private Button save;
    }
}