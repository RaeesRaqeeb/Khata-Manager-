
namespace Store_Management_system
{
    partial class Edit_item
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
            delete_item = new Button();
            itemComboBox = new ComboBox();
            label1 = new Label();
            Back = new Button();
            editing_item_info = new Button();
            new_price = new TextBox();
            new_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // delete_item
            // 
            delete_item.Location = new Point(140, 119);
            delete_item.Name = "delete_item";
            delete_item.Size = new Size(75, 23);
            delete_item.TabIndex = 0;
            delete_item.Text = "Delete";
            delete_item.UseVisualStyleBackColor = true;
            delete_item.Click += delete_item_Click;
            // 
            // itemComboBox
            // 
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(111, 90);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(121, 23);
            itemComboBox.TabIndex = 12;
            itemComboBox.SelectedIndexChanged += itemComboBox_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 13;
            label1.Text = "Deleting/Editing Items";
            // 
            // Back
            // 
            Back.Location = new Point(12, 14);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 14;
            Back.Text = "<-Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // editing_item_info
            // 
            editing_item_info.Location = new Point(129, 241);
            editing_item_info.Name = "editing_item_info";
            editing_item_info.Size = new Size(75, 23);
            editing_item_info.TabIndex = 15;
            editing_item_info.Text = "Edit";
            editing_item_info.UseVisualStyleBackColor = true;
            editing_item_info.Click += editing_item_info_Click;
            // 
            // new_price
            // 
            new_price.Location = new Point(115, 212);
            new_price.Name = "new_price";
            new_price.Size = new Size(100, 23);
            new_price.TabIndex = 16;
            // 
            // new_name
            // 
            new_name.Location = new Point(115, 168);
            new_name.Name = "new_name";
            new_name.Size = new Size(100, 23);
            new_name.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(28, 167);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 18;
            label2.Text = "New Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(30, 211);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 19;
            label3.Text = "New Price";
            // 
            // Edit_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(366, 317);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(new_name);
            Controls.Add(new_price);
            Controls.Add(editing_item_info);
            Controls.Add(Back);
            Controls.Add(label1);
            Controls.Add(itemComboBox);
            Controls.Add(delete_item);
            Name = "Edit_item";
            Text = "deletingItems";
            Load += deletingItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete_item;
        private ComboBox itemComboBox;
        private Label label1;
        private Button Back;
        private Button editing_item_info;
        private EventHandler itemComboBox_SelectedIndexChanged;
        private TextBox new_price;
        private TextBox new_name;
        private Label label2;
        private Label label3;
    }
}