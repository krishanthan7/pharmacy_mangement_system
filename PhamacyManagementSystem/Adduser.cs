using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagementSystem
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO user (user_role, name, DOB, Mobile_No, email,username,password) VALUES (@user_role, @name, @DOB, @Mobile_No, @email,@username,@password);", Form1.connection);
            cmd.Parameters.AddWithValue("@user_role", txtUserRole.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@DOB", txtDob.Text);
            cmd.Parameters.AddWithValue("@Mobile_No", txtMobile.Text);
            cmd.Parameters.AddWithValue("@email", txtMail.Text);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("User Added succesfully");
            Close();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {

        }
    }
}
