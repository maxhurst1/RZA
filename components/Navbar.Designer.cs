namespace RZA.components
{
    partial class Navbar
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
            profileGroupBox = new GroupBox();
            dashboardBtn = new Button();
            signoutBtn = new Button();
            loginBtn = new Button();
            registerBtn = new Button();
            hotelBtn = new Button();
            ticketsBtn = new Button();
            themeBtn = new Button();
            educationalVisits = new Button();
            profileIcon = new PictureBox();
            profileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).BeginInit();
            SuspendLayout();
            // 
            // profileGroupBox
            // 
            profileGroupBox.Controls.Add(dashboardBtn);
            profileGroupBox.Controls.Add(signoutBtn);
            profileGroupBox.Location = new Point(659, 45);
            profileGroupBox.Name = "profileGroupBox";
            profileGroupBox.RightToLeft = RightToLeft.Yes;
            profileGroupBox.Size = new Size(134, 78);
            profileGroupBox.TabIndex = 2;
            profileGroupBox.TabStop = false;
            profileGroupBox.Text = "Profile";
            profileGroupBox.Visible = false;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Popup;
            dashboardBtn.Location = new Point(6, 17);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(122, 23);
            dashboardBtn.TabIndex = 3;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // signoutBtn
            // 
            signoutBtn.FlatStyle = FlatStyle.Popup;
            signoutBtn.Location = new Point(6, 46);
            signoutBtn.Name = "signoutBtn";
            signoutBtn.Size = new Size(122, 23);
            signoutBtn.TabIndex = 4;
            signoutBtn.Text = "Sign Out";
            signoutBtn.UseVisualStyleBackColor = true;
            signoutBtn.Click += signoutBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Location = new Point(718, 12);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Location = new Point(637, 12);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // hotelBtn
            // 
            hotelBtn.FlatStyle = FlatStyle.Popup;
            hotelBtn.Location = new Point(46, 7);
            hotelBtn.Name = "hotelBtn";
            hotelBtn.Size = new Size(75, 23);
            hotelBtn.TabIndex = 1;
            hotelBtn.Text = "Hotel";
            hotelBtn.UseVisualStyleBackColor = true;
            hotelBtn.Click += hotelBtn_Click;
            // 
            // ticketsBtn
            // 
            ticketsBtn.FlatStyle = FlatStyle.Popup;
            ticketsBtn.Location = new Point(127, 7);
            ticketsBtn.Name = "ticketsBtn";
            ticketsBtn.Size = new Size(75, 23);
            ticketsBtn.TabIndex = 2;
            ticketsBtn.Text = "Tickets";
            ticketsBtn.UseVisualStyleBackColor = true;
            ticketsBtn.Click += ticketsBtn_Click;
            // 
            // themeBtn
            // 
            themeBtn.FlatStyle = FlatStyle.Popup;
            themeBtn.Location = new Point(12, 7);
            themeBtn.Name = "themeBtn";
            themeBtn.Size = new Size(28, 23);
            themeBtn.TabIndex = 6;
            themeBtn.Text = "🌙";
            themeBtn.UseVisualStyleBackColor = true;
            themeBtn.Click += themeBtn_Click;
            // 
            // educationalVisits
            // 
            educationalVisits.FlatStyle = FlatStyle.Popup;
            educationalVisits.Location = new Point(208, 7);
            educationalVisits.Name = "educationalVisits";
            educationalVisits.Size = new Size(104, 23);
            educationalVisits.TabIndex = 3;
            educationalVisits.Text = "Education Visits";
            educationalVisits.UseVisualStyleBackColor = true;
            educationalVisits.Click += educationalVisits_Click;
            // 
            // profileIcon
            // 
            profileIcon.Image = Properties.Resources.profile_icon;
            profileIcon.Location = new Point(761, 7);
            profileIcon.Name = "profileIcon";
            profileIcon.Size = new Size(32, 32);
            profileIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            profileIcon.TabIndex = 1;
            profileIcon.TabStop = false;
            profileIcon.Visible = false;
            profileIcon.Click += pictureBox1_Click;
            // 
            // Navbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(educationalVisits);
            Controls.Add(themeBtn);
            Controls.Add(ticketsBtn);
            Controls.Add(hotelBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(profileGroupBox);
            Controls.Add(profileIcon);
            Name = "Navbar";
            Text = "Navbar";
            profileGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox profileGroupBox;
        private Button signoutBtn;
        private Button loginBtn;
        private Button registerBtn;
        private Button hotelBtn;
        private Button ticketsBtn;
        private Button themeBtn;
        private Button dashboardBtn;
        private Button educationalVisits;
        private PictureBox profileIcon;
    }
}