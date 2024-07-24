namespace PhamacyManagementSystem
{
    partial class ViewMedicine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMediSearch = new System.Windows.Forms.Label();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(526, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search......................................................................";
            this.textBox1.Size = new System.Drawing.Size(341, 33);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMediSearch
            // 
            this.lblMediSearch.AutoSize = true;
            this.lblMediSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMediSearch.ForeColor = System.Drawing.Color.White;
            this.lblMediSearch.Location = new System.Drawing.Point(324, 54);
            this.lblMediSearch.Name = "lblMediSearch";
            this.lblMediSearch.Size = new System.Drawing.Size(157, 26);
            this.lblMediSearch.TabIndex = 10;
            this.lblMediSearch.Text = "Medicine Name";
            // 
            // btnDel
            // 
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.Location = new System.Drawing.Point(665, 670);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(174, 36);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete Medicine";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(574, 605);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(327, 27);
            this.txtDel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type name in the box to delete";
            // 
            // ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblMediSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(270, 176);
            this.Name = "ViewMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewMedicine";
            this.Load += new System.EventHandler(this.ViewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label lblMediSearch;
        private FontAwesome.Sharp.IconButton btnDel;
        private TextBox txtDel;
        private Label label2;
    }
}