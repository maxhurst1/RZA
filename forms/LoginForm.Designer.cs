namespace RZA.forms
{
    partial class LoginForm
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
            emailField = new TextBox();
            passwordField = new TextBox();
            loginBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // emailField
            // 
            emailField.Location = new Point(68, 6);
            emailField.MaxLength = 50;
            emailField.Name = "emailField";
            emailField.Size = new Size(210, 23);
            emailField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(68, 35);
            passwordField.MaxLength = 50;
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(210, 23);
            passwordField.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Location = new Point(149, 64);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(129, 23);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.FlatStyle = FlatStyle.Popup;
            cancelBtn.Location = new Point(68, 64);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 95);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(emailField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailField;
        private TextBox passwordField;
        private Button loginBtn;
        private Button cancelBtn;
        private Label label1;
        private Label label2;
    }
}