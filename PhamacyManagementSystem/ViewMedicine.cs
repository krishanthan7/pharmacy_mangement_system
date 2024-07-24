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
    public partial class ViewMedicine : Form
    {
        public ViewMedicine()
        {
            InitializeComponent();
        }

        private void ViewMedicine_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDAT = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from medicine";
            MyDAT.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDAT.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from medicine WHERE Medi_name LIKE '" + textBox1.Text + "%'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }
        String username;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE from medicine WHERE Medi_name= '" + txtDel.Text + "'", Form1.connection);
            //cmd.Parameters.AddWithValue("@name", txtDel.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Deleted succesfully");
            Close();
        }
    }
}
