namespace RZA.forms
{
    partial class PaymentForm
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
            paymentBtn = new Button();
            cardnumberField = new TextBox();
            expiryField = new TextBox();
            costLabel = new Label();
            cscodeField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // paymentBtn
            // 
            paymentBtn.FlatStyle = FlatStyle.Popup;
            paymentBtn.Location = new Point(307, 61);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(42, 23);
            paymentBtn.TabIndex = 4;
            paymentBtn.Text = "Pay";
            paymentBtn.UseVisualStyleBackColor = true;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // cardnumberField
            // 
            cardnumberField.Location = new Point(92, 32);
            cardnumberField.MaxLength = 20;
            cardnumberField.Name = "cardnumberField";
            cardnumberField.PlaceholderText = "1234 5678 91011 1213";
            cardnumberField.Size = new Size(257, 23);
            cardnumberField.TabIndex = 1;
            // 
            // expiryField
            // 
            expiryField.Location = new Point(92, 61);
            expiryField.MaxLength = 5;
            expiryField.Name = "expiryField";
            expiryField.PlaceholderText = "04/28";
            expiryField.Size = new Size(91, 23);
            expiryField.TabIndex = 2;
            // 
            // costLabel
            // 
            costLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            costLabel.ImageAlign = ContentAlignment.MiddleLeft;
            costLabel.Location = new Point(95, 7);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(251, 20);
            costLabel.TabIndex = 0;
            costLabel.Text = "placeholder text";
            // 
            // cscodeField
            // 
            cscodeField.Location = new Point(240, 61);
            cscodeField.MaxLength = 3;
            cscodeField.Name = "cscodeField";
            cscodeField.PlaceholderText = "027";
            cscodeField.Size = new Size(61, 23);
            cscodeField.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Card Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 66);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "CSC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 65);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Expiry Date";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 92);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cscodeField);
            Controls.Add(costLabel);
            Controls.Add(expiryField);
            Controls.Add(cardnumberField);
            Controls.Add(paymentBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PaymentForm";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button paymentBtn;
        private TextBox cardnumberField;
        private TextBox expiryField;
        private Label costLabel;
        private TextBox cscodeField;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}