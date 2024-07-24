namespace PhamacyManagementSystem
{
    partial class ModifyMedicine
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            txtUPrice = new TextBox();
            label5 = new Label();
            txtMediName = new TextBox();
            label4 = new Label();
            txtMediNo = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            label2 = new Label();
            txtMediId = new TextBox();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Black;
            iconButton4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(613, 447);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(149, 55);
            iconButton4.TabIndex = 27;
            iconButton4.Text = "Reset";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.SpringGreen;
            iconButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(390, 453);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(149, 49);
            iconButton3.TabIndex = 26;
            iconButton3.Text = "Update Stock";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // txtUPrice
            // 
            txtUPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUPrice.Location = new Point(763, 374);
            txtUPrice.Margin = new Padding(3, 2, 3, 2);
            txtUPrice.Multiline = true;
            txtUPrice.Name = "txtUPrice";
            txtUPrice.Size = new Size(238, 26);
            txtUPrice.TabIndex = 23;
            txtUPrice.TextChanged += txtUPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SpringGreen;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(763, 326);
            label5.Name = "label5";
            label5.Size = new Size(90, 24);
            label5.TabIndex = 22;
            label5.Text = "Unit Price";
            label5.Click += label5_Click;
            // 
            // txtMediName
            // 
            txtMediName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMediName.Location = new Point(153, 257);
            txtMediName.Margin = new Padding(3, 2, 3, 2);
            txtMediName.Multiline = true;
            txtMediName.Name = "txtMediName";
            txtMediName.Size = new Size(238, 26);
            txtMediName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SpringGreen;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(153, 207);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 20;
            label4.Text = "Medicine Name";
            // 
            // txtMediNo
            // 
            txtMediNo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMediNo.Location = new Point(153, 374);
            txtMediNo.Margin = new Padding(3, 2, 3, 2);
            txtMediNo.Multiline = true;
            txtMediNo.Name = "txtMediNo";
            txtMediNo.Size = new Size(238, 26);
            txtMediNo.TabIndex = 19;
            txtMediNo.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SpringGreen;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(153, 326);
            label3.Name = "label3";
            label3.Size = new Size(162, 24);
            label3.TabIndex = 18;
            label3.Text = "Medicine Number";
            label3.Click += label3_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(763, 257);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(238, 26);
            txtQuantity.TabIndex = 17;
            txtQuantity.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SpringGreen;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(763, 207);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 16;
            label2.Text = "Avalailable Quantity";
            label2.Click += label2_Click;
            // 
            // txtMediId
            // 
            txtMediId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMediId.Location = new Point(441, 120);
            txtMediId.Margin = new Padding(3, 2, 3, 2);
            txtMediId.Multiline = true;
            txtMediId.Name = "txtMediId";
            txtMediId.Size = new Size(238, 26);
            txtMediId.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SpringGreen;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(505, 84);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 14;
            label1.Text = "Medicine Id";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Magenta;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(-4, -3);
            label6.Name = "label6";
            label6.Size = new Size(534, 25);
            label6.TabIndex = 28;
            label6.Text = "Please type the correct Medicine ID and  update your stock\r\n";
            label6.Click += label6_Click;
            // 
            // ModifyMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 557);
            Controls.Add(label6);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(txtUPrice);
            Controls.Add(label5);
            Controls.Add(txtMediName);
            Controls.Add(label4);
            Controls.Add(txtMediNo);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtMediId);
            Controls.Add(label1);
            Location = new Point(270, 176);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModifyMedicine";
            StartPosition = FormStartPosition.Manual;
            Text = "ModifyMedicine";
            Load += ModifyMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox txtUPrice;
        private Label label5;
        private TextBox txtMediName;
        private Label label4;
        private TextBox txtMediNo;
        private Label label3;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtMediId;
        private Label label1;
        private Label label6;
    }
}