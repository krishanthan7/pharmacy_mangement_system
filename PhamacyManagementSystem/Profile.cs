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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhamacyManagementSystem
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            label1.Text = "";
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM test;", Form1.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                label1.Text = rdr[0].ToString();
            }
            rdr.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtMail.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtPassword.Clear();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMobile.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("You can not update with empty fields");
            }
            else
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE user SET user_role=@user_role , name=@name, DOB=@DOB, Mobile_No=@Mobile_No, email=@email,password=@password WHERE username= '" + txtUserName.Text + "'", Form1.connection);
                    cmd.Parameters.AddWithValue("@user_role", txtUserRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@DOB", btnDob.Text);
                    cmd.Parameters.AddWithValue("@Mobile_No", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@email", txtMail.Text);
                    //cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Updated succesfully");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please type the User name properly");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
