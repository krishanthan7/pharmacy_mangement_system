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
using System.Xml.Linq;

namespace PhamacyManagementSystem
{
    public partial class View_user : Form
    {
        public View_user()
        {
            InitializeComponent();
        }

        private void View_user_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from user";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
            /*
             MySqlDataAdapter MyDA = new MySqlDataAdapter();
             string sqlSelectAll = ", Form1.connection);
             MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

             DataTable table = new DataTable();
             MyDA.Fill(table);

             BindingSource bSource = new BindingSource();
             bSource.DataSource = table;


             dataGridView1.DataSource = bSource;
             */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE from user WHERE name= '" + txtDel.Text + "'", Form1.connection);
            //cmd.Parameters.AddWithValue("@name", txtDel.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("User Deleted succesfully");
            Close();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from user WHERE name LIKE '"+textBox1.Text+"%'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }
    }
}
