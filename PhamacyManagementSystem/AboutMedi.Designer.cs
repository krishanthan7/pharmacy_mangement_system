namespace PhamacyManagementSystem
{
    partial class AboutMedi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMedi));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 32);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.ForeColor = Color.White;
            label1.Location = new Point(113, 406);
            label1.Name = "label1";
            label1.Size = new Size(198, 105);
            label1.TabIndex = 3;
            label1.Text = "This Pharmacist page is designed to,\r\n\r\n* Store medicine details\r\n* Update medicine details\r\n* Delete Medicine details\r\n* Billing system for Medicines\r\n* Easily find Expired Medicines\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(731, 32);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(409, 478);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.ForeColor = Color.White;
            label2.Location = new Point(380, 421);
            label2.Name = "label2";
            label2.Size = new Size(272, 90);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // AboutMedi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1209, 542);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Location = new Point(280, 176);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AboutMedi";
            StartPosition = FormStartPosition.Manual;
            Text = "AboutMedi";
            Load += AboutMedi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}