namespace PhamacyManagementSystem
{
    partial class SellMedicine
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
            this.txtMediName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNou = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMediId = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMediName
            // 
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediName.Location = new System.Drawing.Point(341, 101);
            this.txtMediName.Multiline = true;
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.Size = new System.Drawing.Size(315, 34);
            this.txtMediName.TabIndex = 3;
            this.txtMediName.TextChanged += new System.EventHandler(this.txtMediName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(341, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(935, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNou
            // 
            this.txtNou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNou.Location = new System.Drawing.Point(337, 386);
            this.txtNou.Multiline = true;
            this.txtNou.Name = "txtNou";
            this.txtNou.Size = new System.Drawing.Size(315, 34);
            this.txtNou.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(337, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "No of Units";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LawnGreen;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(341, 448);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(199, 65);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Add To Cart";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(632, 140);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1010, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "00";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(557, 61);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(99, 34);
            this.iconButton4.TabIndex = 18;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txtListBox
            // 
            this.txtListBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListBox.ForeColor = System.Drawing.Color.White;
            this.txtListBox.FormattingEnabled = true;
            this.txtListBox.ItemHeight = 22;
            this.txtListBox.Location = new System.Drawing.Point(52, 148);
            this.txtListBox.Name = "txtListBox";
            this.txtListBox.Size = new System.Drawing.Size(206, 510);
            this.txtListBox.TabIndex = 22;
            this.txtListBox.SelectedIndexChanged += new System.EventHandler(this.txtListBox_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Available Medicines";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(345, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 2);
            this.panel1.TabIndex = 24;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Red;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.CheckToSlot;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(629, 448);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(208, 65);
            this.iconButton5.TabIndex = 25;
            this.iconButton5.Text = "Remove";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(337, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 2);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(947, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rs";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(947, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1010, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 38);
            this.label9.TabIndex = 28;
            this.label9.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(935, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 38);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total price";
            // 
            // txtMediId
            // 
            this.txtMediId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediId.Location = new System.Drawing.Point(810, 104);
            this.txtMediId.Multiline = true;
            this.txtMediId.Name = "txtMediId";
            this.txtMediId.Size = new System.Drawing.Size(315, 34);
            this.txtMediId.TabIndex = 30;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(1026, 61);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(99, 34);
            this.iconButton3.TabIndex = 31;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(810, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Medicine ID";
            // 
            // SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.txtMediId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtListBox);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNou);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(270, 176);
            this.Name = "SellMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SellMedicine";
            this.Load += new System.EventHandler(this.SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMediName;
        private Label label2;
        private Label label4;
        private TextBox txtNou;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridView1;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox txtSearchBox;
        private ListBox txtListBox;
        private Label label3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel2;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMediId;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label1;
    }
}