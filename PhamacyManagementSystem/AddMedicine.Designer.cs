namespace PhamacyManagementSystem
{
    partial class AddMedicine
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
            this.lblMediId = new System.Windows.Forms.Label();
            this.txtMediID = new System.Windows.Forms.TextBox();
            this.lblManuDate = new System.Windows.Forms.Label();
            this.lblMediNo = new System.Windows.Forms.Label();
            this.lblMediName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMediNo = new System.Windows.Forms.TextBox();
            this.txtMediName = new System.Windows.Forms.TextBox();
            this.dateManuDate = new System.Windows.Forms.DateTimePicker();
            this.dateExpireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblMediId
            // 
            this.lblMediId.AutoSize = true;
            this.lblMediId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMediId.ForeColor = System.Drawing.Color.White;
            this.lblMediId.Location = new System.Drawing.Point(116, 104);
            this.lblMediId.Name = "lblMediId";
            this.lblMediId.Size = new System.Drawing.Size(127, 26);
            this.lblMediId.TabIndex = 0;
            this.lblMediId.Text = "Medicine ID";
            // 
            // txtMediID
            // 
            this.txtMediID.Location = new System.Drawing.Point(116, 136);
            this.txtMediID.Multiline = true;
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.Size = new System.Drawing.Size(346, 35);
            this.txtMediID.TabIndex = 1;
            // 
            // lblManuDate
            // 
            this.lblManuDate.AutoSize = true;
            this.lblManuDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManuDate.ForeColor = System.Drawing.Color.White;
            this.lblManuDate.Location = new System.Drawing.Point(116, 449);
            this.lblManuDate.Name = "lblManuDate";
            this.lblManuDate.Size = new System.Drawing.Size(186, 26);
            this.lblManuDate.TabIndex = 2;
            this.lblManuDate.Text = "Manufaturing Date";
            // 
            // lblMediNo
            // 
            this.lblMediNo.AutoSize = true;
            this.lblMediNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMediNo.ForeColor = System.Drawing.Color.White;
            this.lblMediNo.Location = new System.Drawing.Point(116, 338);
            this.lblMediNo.Name = "lblMediNo";
            this.lblMediNo.Size = new System.Drawing.Size(179, 26);
            this.lblMediNo.TabIndex = 3;
            this.lblMediNo.Text = "Medicine Number";
            // 
            // lblMediName
            // 
            this.lblMediName.AutoSize = true;
            this.lblMediName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMediName.ForeColor = System.Drawing.Color.White;
            this.lblMediName.Location = new System.Drawing.Point(116, 228);
            this.lblMediName.Name = "lblMediName";
            this.lblMediName.Size = new System.Drawing.Size(157, 26);
            this.lblMediName.TabIndex = 4;
            this.lblMediName.Text = "Medicine Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(809, 231);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(141, 26);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Price Per Unit";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(809, 104);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 26);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpireDate.ForeColor = System.Drawing.Color.White;
            this.lblExpireDate.Location = new System.Drawing.Point(116, 558);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(120, 26);
            this.lblExpireDate.TabIndex = 7;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(809, 260);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(346, 35);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(809, 142);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(346, 35);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtMediNo
            // 
            this.txtMediNo.Location = new System.Drawing.Point(116, 371);
            this.txtMediNo.Multiline = true;
            this.txtMediNo.Name = "txtMediNo";
            this.txtMediNo.Size = new System.Drawing.Size(346, 35);
            this.txtMediNo.TabIndex = 10;
            // 
            // txtMediName
            // 
            this.txtMediName.Location = new System.Drawing.Point(116, 256);
            this.txtMediName.Multiline = true;
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.Size = new System.Drawing.Size(346, 35);
            this.txtMediName.TabIndex = 11;
            // 
            // dateManuDate
            // 
            this.dateManuDate.Location = new System.Drawing.Point(116, 488);
            this.dateManuDate.Name = "dateManuDate";
            this.dateManuDate.Size = new System.Drawing.Size(346, 27);
            this.dateManuDate.TabIndex = 12;
            // 
            // dateExpireDate
            // 
            this.dateExpireDate.Location = new System.Drawing.Point(116, 596);
            this.dateExpireDate.Name = "dateExpireDate";
            this.dateExpireDate.Size = new System.Drawing.Size(346, 27);
            this.dateExpireDate.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(807, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 45);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(1012, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 45);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 743);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateExpireDate);
            this.Controls.Add(this.dateManuDate);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.txtMediNo);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblMediName);
            this.Controls.Add(this.lblMediNo);
            this.Controls.Add(this.lblManuDate);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.lblMediId);
            this.Location = new System.Drawing.Point(270, 176);
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMediId;
        private TextBox txtMediID;
        private Label lblManuDate;
        private Label lblMediNo;
        private Label lblMediName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblExpireDate;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtMediNo;
        private TextBox txtMediName;
        private DateTimePicker dateManuDate;
        private DateTimePicker dateExpireDate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}