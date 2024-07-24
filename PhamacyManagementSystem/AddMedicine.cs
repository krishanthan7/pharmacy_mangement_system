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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNo.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO medicine (MediId, Medi_name, Medi_no, Manufacture_date,Expire_Date, quantity, unit_price) VALUES (@MediId, @Medi_name, @Medi_no, @manu_date,@expire_date,@quantity,@unit_price);", Form1.connection);
            cmd.Parameters.AddWithValue("@MediId", txtMediID.Text);
            cmd.Parameters.AddWithValue("@Medi_name", txtMediName.Text);
            cmd.Parameters.AddWithValue("@Medi_no", txtMediNo.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@@manu_date", dateManuDate.Text);
            cmd.Parameters.AddWithValue("@expire_date", dateExpireDate.Text);
            cmd.Parameters.AddWithValue("@unit_price", txtUnitPrice.Text);


            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Medicine Added succesfully");
            Close();
        }
    }
}
