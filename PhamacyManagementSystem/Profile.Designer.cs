namespace PhamacyManagementSystem
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            label5 = new Label();
            txtMobile = new TextBox();
            btnProUserName = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtUserRole = new ComboBox();
            btnDob = new DateTimePicker();
            label8 = new Label();
            txt = new Label();
            txtUserName = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 247);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(31, 30, 70);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(659, 500);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 36);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Update";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(659, 26);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 4;
            label2.Text = "User Role";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(659, 97);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(659, 121);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 25);
            txtName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(659, 176);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 8;
            label4.Text = "E-Mail";
            label4.Click += label4_Click;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(659, 200);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(294, 25);
            txtMail.TabIndex = 7;
            txtMail.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(659, 320);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 10;
            label5.Text = "Mobile No";
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobile.Location = new Point(659, 347);
            txtMobile.Margin = new Padding(3, 2, 3, 2);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(294, 25);
            txtMobile.TabIndex = 9;
            // 
            // btnProUserName
            // 
            btnProUserName.BackColor = Color.FromArgb(31, 30, 70);
            btnProUserName.ForeColor = Color.White;
            btnProUserName.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProUserName.IconColor = Color.Black;
            btnProUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProUserName.Location = new Point(838, 496);
            btnProUserName.Margin = new Padding(3, 2, 3, 2);
            btnProUserName.Name = "btnProUserName";
            btnProUserName.Size = new Size(115, 36);
            btnProUserName.TabIndex = 11;
            btnProUserName.Text = "Reset";
            btnProUserName.UseVisualStyleBackColor = false;
            btnProUserName.Click += iconButton2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(659, 251);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 13;
            label6.Text = "Date Of Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(659, 411);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(659, 435);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 25);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += textBox6_TextChanged;
            // 
            // txtUserRole
            // 
            txtUserRole.FormattingEnabled = true;
            txtUserRole.Items.AddRange(new object[] { "Admin", "Pharmacist" });
            txtUserRole.Location = new Point(659, 49);
            txtUserRole.Margin = new Padding(3, 2, 3, 2);
            txtUserRole.Name = "txtUserRole";
            txtUserRole.Size = new Size(294, 23);
            txtUserRole.TabIndex = 16;
            // 
            // btnDob
            // 
            btnDob.Location = new Point(659, 277);
            btnDob.Margin = new Padding(3, 2, 3, 2);
            btnDob.Name = "btnDob";
            btnDob.Size = new Size(294, 23);
            btnDob.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(82, 370);
            label8.Name = "label8";
            label8.Size = new Size(186, 19);
            label8.TabIndex = 18;
            label8.Text = "Check Before you update !!!";
            label8.Click += label8_Click;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt.ForeColor = Color.White;
            txt.Location = new Point(82, 411);
            txt.Name = "txt";
            txt.Size = new Size(94, 21);
            txt.TabIndex = 20;
            txt.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(82, 453);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(294, 25);
            txtUserName.TabIndex = 19;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(82, 324);
            label9.Name = "label9";
            label9.Size = new Size(291, 19);
            label9.TabIndex = 21;
            label9.Text = "Type the User Name and Update the Profile";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 70);
            ClientSize = new Size(1209, 557);
            Controls.Add(label9);
            Controls.Add(txt);
            Controls.Add(txtUserName);
            Controls.Add(label8);
            Controls.Add(btnDob);
            Controls.Add(txtUserRole);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(btnProUserName);
            Controls.Add(label5);
            Controls.Add(txtMobile);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Location = new Point(270, 176);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            StartPosition = FormStartPosition.Manual;
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtMail;
        private Label label5;
        private TextBox txtMobile;
        private FontAwesome.Sharp.IconButton btnProUserName;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private ComboBox txtUserRole;
        private DateTimePicker btnDob;
        private Label label8;
        private Label txt;
        private TextBox txtUserName;
        private Label label9;
    }
}