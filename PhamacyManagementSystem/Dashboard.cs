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
using static System.Net.Mime.MediaTypeNames;

namespace PhamacyManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
            MySqlCommand cmd = new MySqlCommand("SELECT user_role FROM user WHERE user_role = 'Pharmacist'", Form1.connection);

            int count=0;
            string role = "";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                role = rdr[0].ToString();
                if (role == "Pharmacist")
                {
                    count += 1;
                //lblCount.Text += ", " + rdr[0].ToString();
                }
            }
            rdr.Close();
            lblCount.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT user_role FROM user WHERE user_role = 'Administrator'", Form1.connection);

            int count = 0;
            string role = "";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                role = rdr[0].ToString();
                if (role == "Administrator")
                {
                    count += 1;
                    //lblCount.Text += ", " + rdr[0].ToString();
                }
            }
            rdr.Close();
            lblAdd.Text = count.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
