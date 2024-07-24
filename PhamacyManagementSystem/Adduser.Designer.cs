namespace PhamacyManagementSystem
{
    partial class Adduser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMail = new TextBox();
            txtUserName = new TextBox();
            txtName = new TextBox();
            txtMobile = new TextBox();
            txtPassword = new TextBox();
            txtUserRole = new ComboBox();
            txtDob = new DateTimePicker();
            panel2 = new Panel();
            btnSignup = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "User Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 303);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Mobile No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 210);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 120);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(649, 211);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(649, 119);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 5;
            label6.Text = "User Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(46, 395);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 6;
            label7.Text = "E-mail Address";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.Black;
            txtMail.Location = new Point(46, 431);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(355, 31);
            txtMail.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(649, 158);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(355, 31);
            txtUserName.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(46, 149);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(355, 31);
            txtName.TabIndex = 10;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobile.ForeColor = Color.Black;
            txtMobile.Location = new Point(46, 334);
            txtMobile.Margin = new Padding(3, 2, 3, 2);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(355, 31);
            txtMobile.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(649, 241);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(355, 31);
            txtPassword.TabIndex = 13;
            // 
            // txtUserRole
            // 
            txtUserRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserRole.FormattingEnabled = true;
            txtUserRole.Items.AddRange(new object[] { "Administrator", "Pharmacist" });
            txtUserRole.Location = new Point(46, 65);
            txtUserRole.Margin = new Padding(3, 2, 3, 2);
            txtUserRole.Name = "txtUserRole";
            txtUserRole.Size = new Size(355, 29);
            txtUserRole.TabIndex = 14;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(46, 244);
            txtDob.Margin = new Padding(3, 2, 3, 2);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(355, 23);
            txtDob.TabIndex = 15;
            txtDob.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 70);
            panel2.Location = new Point(538, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 380);
            panel2.TabIndex = 16;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(31, 30, 70);
            btnSignup.ForeColor = Color.White;
            btnSignup.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            btnSignup.IconColor = Color.White;
            btnSignup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignup.IconSize = 40;
            btnSignup.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignup.Location = new Point(649, 312);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(148, 53);
            btnSignup.TabIndex = 17;
            btnSignup.Text = "Sign Up";
            btnSignup.TextAlign = ContentAlignment.MiddleLeft;
            btnSignup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(31, 30, 70);
            btnReset.ForeColor = Color.White;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Scribd;
            btnReset.IconColor = Color.White;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 40;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(856, 312);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(148, 53);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // Adduser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 70);
            ClientSize = new Size(1209, 557);
            Controls.Add(btnReset);
            Controls.Add(btnSignup);
            Controls.Add(panel2);
            Controls.Add(txtDob);
            Controls.Add(txtUserRole);
            Controls.Add(txtPassword);
            Controls.Add(txtMobile);
            Controls.Add(txtName);
            Controls.Add(txtUserName);
            Controls.Add(txtMail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Location = new Point(270, 176);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Adduser";
            StartPosition = FormStartPosition.Manual;
            Text = "Adding user";
            Load += Adduser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMail;
        private TextBox txtUserName;
        private TextBox txtName;
        private TextBox txtMobile;
        private TextBox txtPassword;
        private ComboBox txtUserRole;
        private DateTimePicker txtDob;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSignup;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}