namespace PhamacyManagementSystem
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(442, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 120);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(863, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(476, 668);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 120);
            this.label1.TabIndex = 8;
            this.label1.Text = "This Pharmacist page is designed to,\r\n\r\n* Store Phamacist details\r\n* Update Phama" +
    "cist details\r\n* Delete Phamacist details\r\n* Easily find detials of Phamacists\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1382, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(270, 176);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}