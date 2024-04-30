namespace RZA.forms
{
    partial class BookingForm
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
            checkInDate = new DateTimePicker();
            checkOutDate = new DateTimePicker();
            costLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            paymentBtn = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // checkInDate
            // 
            checkInDate.Location = new Point(209, 7);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(200, 23);
            checkInDate.TabIndex = 1;
            checkInDate.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // checkOutDate
            // 
            checkOutDate.Location = new Point(209, 39);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(200, 23);
            checkOutDate.TabIndex = 2;
            checkOutDate.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(191, 88);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(92, 15);
            costLabel.TabIndex = 0;
            costLabel.Text = "placeholder text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 11);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Check In Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 42);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "Check Out Date";
            // 
            // paymentBtn
            // 
            paymentBtn.FlatStyle = FlatStyle.Popup;
            paymentBtn.Location = new Point(113, 84);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(75, 23);
            paymentBtn.TabIndex = 3;
            paymentBtn.Text = "Pay";
            paymentBtn.UseVisualStyleBackColor = true;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(7, 7);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 113);
            Controls.Add(pictureBox);
            Controls.Add(paymentBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(costLabel);
            Controls.Add(checkOutDate);
            Controls.Add(checkInDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookingForm";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker checkInDate;
        private DateTimePicker checkOutDate;
        private Label costLabel;
        private Label label1;
        private Label label2;
        private Button paymentBtn;
        private PictureBox pictureBox;
    }
}