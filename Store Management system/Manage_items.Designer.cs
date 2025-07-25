namespace Store_Management_system
{
    partial class Manage_items
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
            Unitpricebox = new TextBox();
            itemnamebox = new TextBox();
            label2 = new Label();
            add_item = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            itemsDataGridView = new DataGridView();
            Back = new Button();
            searchItem = new Button();
            Delete_items = new Button();
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(116, 23);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 32;
            label5.Text = "Adding New Items";
            label5.Click += label5_Click;
            // 
            // Unitpricebox
            // 
            Unitpricebox.Location = new Point(116, 101);
            Unitpricebox.Multiline = true;
            Unitpricebox.Name = "Unitpricebox";
            Unitpricebox.Size = new Size(172, 28);
            Unitpricebox.TabIndex = 28;
            // 
            // itemnamebox
            // 
            itemnamebox.Location = new Point(116, 67);
            itemnamebox.Multiline = true;
            itemnamebox.Name = "itemnamebox";
            itemnamebox.Size = new Size(172, 28);
            itemnamebox.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 24;
            label2.Text = "Unit Price";
            // 
            // add_item
            // 
            add_item.Location = new Point(298, 106);
            add_item.Name = "add_item";
            add_item.Size = new Size(61, 23);
            add_item.TabIndex = 23;
            add_item.Text = "ADD";
            add_item.UseVisualStyleBackColor = true;
            add_item.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(2, 67);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 22;
            label1.Text = "Item Name";
            label1.Click += label1_Click;
            // 
            // itemsDataGridView
            // 
            itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsDataGridView.Location = new Point(14, 135);
            itemsDataGridView.Name = "itemsDataGridView";
            itemsDataGridView.Size = new Size(345, 302);
            itemsDataGridView.TabIndex = 33;
            itemsDataGridView.CellContentClick += itemsDataGridView_CellContentClick;
            // 
            // Back
            // 
            Back.Location = new Point(14, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 34;
            Back.Text = "<- Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // searchItem
            // 
            searchItem.Location = new Point(285, 12);
            searchItem.Name = "searchItem";
            searchItem.Size = new Size(75, 23);
            searchItem.TabIndex = 35;
            searchItem.Text = "Seach item";
            searchItem.UseVisualStyleBackColor = true;
            searchItem.Click += searchItem_Click;
            // 
            // Delete_items
            // 
            Delete_items.Location = new Point(25, 403);
            Delete_items.Name = "Delete_items";
            Delete_items.Size = new Size(99, 23);
            Delete_items.TabIndex = 36;
            Delete_items.Text = "Delete/Edit  Items";
            Delete_items.UseVisualStyleBackColor = true;
            Delete_items.Click += Delete_items_Click;
            // 
            // Manage_items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(372, 438);
            Controls.Add(Delete_items);
            Controls.Add(searchItem);
            Controls.Add(Back);
            Controls.Add(itemsDataGridView);
            Controls.Add(label5);
            Controls.Add(Unitpricebox);
            Controls.Add(itemnamebox);
            Controls.Add(label2);
            Controls.Add(add_item);
            Controls.Add(label1);
            Name = "Manage_items";
            Text = "Manage_items";
            Load += Manage_items_Load;
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox Unitpricebox;
        private TextBox itemnamebox;
        private Label label2;
        private Button add_item;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView itemsDataGridView;
        private Button Back;
        private Button searchItem;
        private Button Delete_items;
    }
}