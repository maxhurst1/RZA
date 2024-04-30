namespace RZA.forms
{
    partial class RegistrationForm
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
            cancelBtn = new Button();
            registerBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            forenameField = new TextBox();
            surnameField = new TextBox();
            countryBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            phonenumberField = new TextBox();
            addressField = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            genderBox = new ComboBox();
            tosCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // emailField
            // 
            emailField.Location = new Point(99, 35);
            emailField.MaxLength = 100;
            emailField.Name = "emailField";
            emailField.PlaceholderText = "eg john.doe@gmail.com";
            emailField.Size = new Size(319, 23);
            emailField.TabIndex = 3;
            // 
            // passwordField
            // 
            passwordField.BackColor = SystemColors.Window;
            passwordField.ForeColor = SystemColors.WindowText;
            passwordField.Location = new Point(99, 121);
            passwordField.MaxLength = 50;
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.PlaceholderText = "Must be 8 characters";
            passwordField.Size = new Size(319, 23);
            passwordField.TabIndex = 8;
            // 
            // cancelBtn
            // 
            cancelBtn.FlatStyle = FlatStyle.Popup;
            cancelBtn.Location = new Point(18, 172);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Location = new Point(99, 172);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(319, 23);
            registerBtn.TabIndex = 10;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Forename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 8);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 38);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // forenameField
            // 
            forenameField.Location = new Point(99, 5);
            forenameField.MaxLength = 50;
            forenameField.Name = "forenameField";
            forenameField.Size = new Size(127, 23);
            forenameField.TabIndex = 1;
            // 
            // surnameField
            // 
            surnameField.Location = new Point(291, 5);
            surnameField.MaxLength = 50;
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(127, 23);
            surnameField.TabIndex = 2;
            // 
            // countryBox
            // 
            countryBox.FormattingEnabled = true;
            countryBox.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            countryBox.Location = new Point(291, 64);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(127, 23);
            countryBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 67);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 67);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Phone number";
            // 
            // phonenumberField
            // 
            phonenumberField.Location = new Point(99, 64);
            phonenumberField.MaxLength = 15;
            phonenumberField.Name = "phonenumberField";
            phonenumberField.Size = new Size(127, 23);
            phonenumberField.TabIndex = 4;
            // 
            // addressField
            // 
            addressField.Location = new Point(99, 93);
            addressField.MaxLength = 50;
            addressField.Name = "addressField";
            addressField.Size = new Size(127, 23);
            addressField.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 96);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 0;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 96);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 0;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 124);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 0;
            label8.Text = "Password";
            // 
            // genderBox
            // 
            genderBox.ForeColor = SystemColors.WindowText;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderBox.Location = new Point(291, 93);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(127, 23);
            genderBox.TabIndex = 7;
            // 
            // tosCheckBox
            // 
            tosCheckBox.AutoSize = true;
            tosCheckBox.Location = new Point(99, 148);
            tosCheckBox.Name = "tosCheckBox";
            tosCheckBox.Size = new Size(94, 19);
            tosCheckBox.TabIndex = 9;
            tosCheckBox.Text = "Agree to TOS";
            tosCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 199);
            Controls.Add(tosCheckBox);
            Controls.Add(genderBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(addressField);
            Controls.Add(phonenumberField);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(countryBox);
            Controls.Add(surnameField);
            Controls.Add(forenameField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerBtn);
            Controls.Add(cancelBtn);
            Controls.Add(passwordField);
            Controls.Add(emailField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailField;
        private TextBox passwordField;
        private Button cancelBtn;
        private Button registerBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox forenameField;
        private TextBox surnameField;
        private ComboBox countryBox;
        private Label label4;
        private Label label5;
        private TextBox phonenumberField;
        private TextBox addressField;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox genderBox;
        private CheckBox tosCheckBox;
    }
}