﻿namespace RZA.controls
{
    partial class HotelContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            descriptionLabel = new Label();
            bookBtn = new Button();
            priceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(109, 3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(225, 74);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Blank description.";
            // 
            // bookBtn
            // 
            bookBtn.FlatStyle = FlatStyle.Popup;
            bookBtn.Location = new Point(259, 80);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(75, 23);
            bookBtn.TabIndex = 2;
            bookBtn.Text = "Book";
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(153, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.RightToLeft = RightToLeft.Yes;
            priceLabel.Size = new Size(100, 23);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HotelContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priceLabel);
            Controls.Add(bookBtn);
            Controls.Add(descriptionLabel);
            Controls.Add(pictureBox);
            Name = "HotelContainer";
            Size = new Size(336, 106);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label descriptionLabel;
        private Button bookBtn;
        private Label priceLabel;
    }
}
