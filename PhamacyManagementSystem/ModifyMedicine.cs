using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PhamacyManagementSystem
{
    public partial class ModifyMedicine : Form
    {
        public ModifyMedicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (txtMediId.Text == "" || txtMediName.Text == "" || txtMediNo.Text == "" || txtQuantity.Text == "" || txtUPrice.Text == "")
            {
                MessageBox.Show("You can not update with empty fields");
            }
            else
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE medicine SET Medi_name=@Medi_name , Medi_no=@Medi_no, quantity=@quantity, unit_price=@unit_price WHERE MediId= '" + txtMediId.Text + "'", Form1.connection);
                    cmd.Parameters.AddWithValue("@Medi_name", txtMediName.Text);
                    cmd.Parameters.AddWithValue("@Medi_no", txtMediNo.Text);

                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@unit_price", txtUPrice.Text);



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medicine Updated succesfully");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please type the Medicine Id properly");
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtMediName.Clear();
            txtMediNo.Clear();
            txtQuantity.Clear();
            txtUPrice.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
