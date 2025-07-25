namespace Store_Management_system
{
    partial class signup
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
            signup_button = new Button();
            label4 = new Label();
            password_input = new TextBox();
            username_input = new TextBox();
            password = new Label();
            username = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // signup_button
            // 
            signup_button.Location = new Point(101, 269);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(75, 23);
            signup_button.TabIndex = 15;
            signup_button.Text = "Sign up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(0, 331);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 14;
            label4.Text = "Made by: Raqeeb";
            // 
            // password_input
            // 
            password_input.Location = new Point(56, 222);
            password_input.Multiline = true;
            password_input.Name = "password_input";
            password_input.Size = new Size(181, 30);
            password_input.TabIndex = 13;
            password_input.TextChanged += password_input_TextChanged;
            // 
            // username_input
            // 
            username_input.Location = new Point(56, 158);
            username_input.Multiline = true;
            username_input.Name = "username_input";
            username_input.Size = new Size(181, 30);
            username_input.TabIndex = 12;
            username_input.TextChanged += username_input_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 15F);
            password.ForeColor = SystemColors.ControlLightLight;
            password.Location = new Point(56, 191);
            password.Name = "password";
            password.Size = new Size(93, 28);
            password.TabIndex = 11;
            password.Text = "Password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 15F);
            username.ForeColor = SystemColors.ControlLightLight;
            username.Location = new Point(56, 127);
            username.Name = "username";
            username.Size = new Size(108, 28);
            username.TabIndex = 10;
            username.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 25F);
            label1.Location = new Point(1, 19);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 9;
            label1.Text = "Khatah Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(69, 80);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 16;
            label2.Text = "Create new User";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(331, 407);
            Controls.Add(label2);
            Controls.Add(signup_button);
            Controls.Add(label4);
            Controls.Add(password_input);
            Controls.Add(username_input);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_button;
        private Label label4;
        private TextBox password_input;
        private TextBox username_input;
        private Label password;
        private Label username;
        private Label label1;
        private Label label2;
    }
}