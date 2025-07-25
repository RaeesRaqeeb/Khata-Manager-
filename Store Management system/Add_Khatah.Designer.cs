namespace Store_Management_system
{
    partial class Add_Khatah
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
            panel1 = new Panel();
            itemsDataGridView = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            Itemname = new DataGridViewTextBoxColumn();
            Unitprice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            quantityTextBox = new TextBox();
            label4 = new Label();
            unitPriceTextBox = new TextBox();
            addButton = new Button();
            saveButton = new Button();
            customerComboBox = new ComboBox();
            itemComboBox = new ComboBox();
            previous_window = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(itemsDataGridView);
            panel1.Location = new Point(58, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 328);
            panel1.TabIndex = 1;
            // 
            // itemsDataGridView
            // 
            itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemID, Itemname, Unitprice, Quantity, Total });
            itemsDataGridView.Location = new Point(15, 12);
            itemsDataGridView.Name = "itemsDataGridView";
            itemsDataGridView.Size = new Size(526, 302);
            itemsDataGridView.TabIndex = 0;
            itemsDataGridView.CellContentClick += itemsDataGridView_CellContentClick;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "Item ID";
            ItemID.Name = "ItemID";
            // 
            // Itemname
            // 
            Itemname.HeaderText = "Item name";
            Itemname.Name = "Itemname";
            // 
            // Unitprice
            // 
            Unitprice.HeaderText = "Quantity";
            Unitprice.Name = "Unitprice";
            Unitprice.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Unit Price";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(217, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 2;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(353, 20);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(353, 51);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(459, 20);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 6;
            label4.Text = "Unit Price";
            // 
            // unitPriceTextBox
            // 
            unitPriceTextBox.Location = new Point(459, 51);
            unitPriceTextBox.Name = "unitPriceTextBox";
            unitPriceTextBox.Size = new Size(100, 23);
            unitPriceTextBox.TabIndex = 7;
            unitPriceTextBox.TextChanged += unitprice_TextChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(565, 51);
            addButton.Name = "addButton";
            addButton.Size = new Size(62, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(508, 413);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 25);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(58, 50);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(137, 23);
            customerComboBox.TabIndex = 10;
            // 
            // itemComboBox
            // 
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(217, 50);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(121, 23);
            itemComboBox.TabIndex = 11;
            // 
            // previous_window
            // 
            previous_window.Location = new Point(3, 12);
            previous_window.Name = "previous_window";
            previous_window.Size = new Size(58, 24);
            previous_window.TabIndex = 12;
            previous_window.Text = "<-Back";
            previous_window.UseVisualStyleBackColor = true;
            previous_window.Click += previous_window_Click;
            // 
            // Add_Khatah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(639, 450);
            Controls.Add(previous_window);
            Controls.Add(itemComboBox);
            Controls.Add(customerComboBox);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(unitPriceTextBox);
            Controls.Add(label4);
            Controls.Add(quantityTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Add_Khatah";
            Text = "Add_Khatah";
            Load += Add_Khatah_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox quantityTextBox;
        private Label label4;
        private TextBox unitPriceTextBox;
        private DataGridView itemsDataGridView;
        private Button addButton;
        private Button saveButton;
        private ComboBox customerComboBox;
        private ComboBox itemComboBox;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Itemname;
        private DataGridViewTextBoxColumn Unitprice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Button previous_window;
    }
}