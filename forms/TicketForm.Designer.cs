namespace RZA.forms
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            dateTimePicker = new DateTimePicker();
            bookBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            costLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(201, 57);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // bookBtn
            // 
            bookBtn.FlatStyle = FlatStyle.Popup;
            bookBtn.Location = new Point(201, 86);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(75, 23);
            bookBtn.TabIndex = 2;
            bookBtn.Text = "Book";
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(164, 9);
            label2.Name = "label2";
            label2.Size = new Size(237, 45);
            label2.TabIndex = 0;
            label2.Text = "Come visit the zoo and meet the animals!\r\nThe zoo is open everyday with opening times from 9:00 till 20:00";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(282, 90);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(92, 15);
            costLabel.TabIndex = 0;
            costLabel.Text = "placeholder text";
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 116);
            Controls.Add(costLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bookBtn);
            Controls.Add(dateTimePicker);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TicketForm";
            Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Button bookBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label costLabel;
    }
}