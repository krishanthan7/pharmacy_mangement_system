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
    public partial class phadashboard : Form
    {
        public phadashboard()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void phadashboard_Load(object sender, EventArgs e)
        {
            //01 total count
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(Medi_name) FROM medicine", Form1.connection);

            string role = "";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                role = rdr[0].ToString();
                label1.Text =  rdr[0].ToString();
                
            }
            rdr.Close();
            //lblCount.Text = count.ToString();

            //02 <500
            MySqlCommand kmd = new MySqlCommand("SELECT COUNT(Medi_name) FROM medicine WHERE unit_price < 500", Form1.connection);

            string rol = "";
            MySqlDataReader rdravg = kmd.ExecuteReader();
            while (rdravg.Read())
            {
                rol = rdravg[0].ToString();
                label2.Text = rdravg[0].ToString();

            }
            rdravg.Close();

            MySqlCommand jmd = new MySqlCommand("SELECT COUNT(Medi_name) FROM medicine WHERE unit_price > 500", Form1.connection);

            string ro = "";
            MySqlDataReader rdr500 = jmd.ExecuteReader();
            while (rdr500.Read())
            {
                ro = rdr500[0].ToString();
                label4.Text = rdr500[0].ToString();

            }
            rdr500.Close();

            //
            MySqlCommand amd = new MySqlCommand("SELECT COUNT(Medi_name) FROM medicine WHERE unit_price > 1000", Form1.connection);

            string r = "";
            MySqlDataReader rdr1000 = amd.ExecuteReader();
            while (rdr1000.Read())
            {
                r = rdr1000[0].ToString();
                label3.Text = rdr1000[0].ToString();

            }
            rdr1000.Close();

            //avg
            MySqlCommand bmd = new MySqlCommand("SELECT AVG(unit_price) FROM medicine", Form1.connection);

            string rom = "";
            MySqlDataReader rdrave = bmd.ExecuteReader();
            while (rdrave.Read())
            {
                rom = rdrave[0].ToString();
                label6.Text = rdrave[0].ToString();

            }
            rdrave.Close();


        }
    }
}
