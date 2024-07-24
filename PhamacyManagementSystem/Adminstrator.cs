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
    public partial class Adminstrator : Form
    {
        public Adminstrator(String name)
        {
            InitializeComponent();
            Text = "Hello, " + name;

            /*label1.Text = "";
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM test;", Form1.connection);


            //
            MySqlCommand cmd = new MySqlCommand("SELECT role FROM user where name = @name AND password = @pass", Form1.connection);

            string role = "";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
            role = rdr[0].ToString();
                label1.Text += ", " + rdr[0].ToString();
            }
            rdr.Close();
            
             if (role == "admin"){
                    form1
            }
             */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            btnHome.Text = "DashBoard";
            btnHome.ForeColor = Color.LightGreen;
            btnHome.IconColor = Color.LightGreen;

            Dashboard ds = new Dashboard();
            ds.ShowDialog();
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            btnHome.Text = "View user";
            btnHome.ForeColor = Color.LightGreen;
            btnHome.IconColor = Color.LightGreen;

            View_user vu = new View_user();
            vu.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
                    }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.DeepPink;
            btnDashboard.IconColor = Color.DeepPink;
        }

        private void btnAdduser_MouseEnter(object sender, EventArgs e)
        {
            btnAddUser.ForeColor = Color.Firebrick;
            btnAddUser.IconColor = Color.Firebrick;
        }

        private void btnViewuser_MouseEnter(object sender, EventArgs e)
        {
            btnViewUser.ForeColor = Color.Gold;
            btnViewUser.IconColor = Color.Gold;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.Yellow;
            btnProfile.IconColor = Color.Yellow;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.OrangeRed;
            btnLogout.IconColor = Color.OrangeRed;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconColor = Color.White;
        }

        private void btnAdduser_MouseLeave(object sender, EventArgs e)
        {
            btnAddUser.ForeColor = Color.White;
            btnAddUser.IconColor = Color.White;
        }

        private void btnViewuser_MouseLeave(object sender, EventArgs e)
        {
            btnViewUser.ForeColor = Color.White;
            btnViewUser.IconColor = Color.White;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;
            btnProfile.IconColor = Color.White;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
            btnLogout.IconColor = Color.White;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            btnHome.Text = "Add user";
            btnHome.ForeColor = Color.LightGreen;
            btnHome.IconColor = Color.LightGreen;

            Adduser au = new Adduser();
            au.ShowDialog();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnHome.Text = "Profile";
            btnHome.ForeColor = Color.LightGreen;
            btnHome.IconColor = Color.LightGreen;

            Profile pf = new Profile();
            pf.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnHome.Text = "Log out";
            btnHome.ForeColor = Color.LightGreen;
            btnHome.IconColor = Color.LightGreen;

            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.ShowDialog();
        }

        private void btnProfile_MouseLeave_1(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;
            btnProfile.IconColor = Color.White;
        }

        private void btnProfile_MouseEnter_1(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.IndianRed;
            btnProfile.IconColor = Color.IndianRed;
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Red;
            btnAbout.IconColor = Color.Red;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.White;
            btnAbout.IconColor = Color.White;
        }
    }
}
