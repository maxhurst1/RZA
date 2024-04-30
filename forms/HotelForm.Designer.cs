namespace RZA.forms
{
    partial class HotelForm
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
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.Location = new Point(7, 64);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(361, 355);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(361, 55);
            label1.TabIndex = 0;
            label1.Text = "Book a room from our wide range of high quality rooms.\r\nEvery room we offer is unique, pick one that suits you best.\r\nAll hotel tickets will be accepted for enterance into the zoo.";
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 424);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HotelForm";
            Text = "Room Booking";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel;
        private Label label1;
    }
}