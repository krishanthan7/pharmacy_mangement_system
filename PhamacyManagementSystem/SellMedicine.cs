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
using static System.Net.Mime.MediaTypeNames;

namespace PhamacyManagementSystem
{
    public partial class SellMedicine : Form
    {
        public SellMedicine()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
           // lbl1.Text = "";
            MySqlCommand cmd = new MySqlCommand("SELECT Medi_name FROM medicine WHERE quantity > '0';", Form1.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //lbl1.Text += ", " + rdr[0].ToString();
                txtListBox.Items.Add(rdr[0].ToString());

            }
            rdr.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT medi_name,unit_price,Expire_Date, Medi_no FROM medicine WHERE Medi_name = '" + txtMediName.Text + "'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }

       // List<CartItem> cart = new List<CartItem>();

        private void iconButton1_Click(object sender, EventArgs e)
        {

           // cart.Add(new CartItem(txtMediName.Text, 200, 20));

            double total;
            double unitprice =0; 
            MySqlCommand cmd = new MySqlCommand("SELECT unit_price FROM medicine WHERE quantity > '0' AND Medi_name = @name;", Form1.connection);
            cmd.Parameters.AddWithValue("@name", txtMediName.Text);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //lbl1.Text += ", " + rdr[0].ToString();
                unitprice += (Convert.ToDouble(rdr[0]));

            }
            rdr.Close();
            total = Convert.ToDouble(txtNou.Text) * unitprice;
            label7.Text = total.ToString();
           
            double x =Convert.ToDouble(label9.Text);
            label9.Text = (total + x).ToString();
            //label9.Text += (total + Convert.ToDouble(label9.Text));

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            txtListBox.Items.Clear();
            
         

        }

        private void txtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNou.Clear();
            String name = txtListBox.GetItemText(txtListBox.SelectedItem);
            txtMediName.Text = name;


        }

        private void txtMediName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(label7.Text); //
            double y = Convert.ToDouble(label9.Text);
            label9.Text = (y-x).ToString();
            label7.Text = ".00";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT medi_name,unit_price,Expire_Date FROM medicine WHERE MediId= '" + txtMediId.Text + "'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Form1.connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
