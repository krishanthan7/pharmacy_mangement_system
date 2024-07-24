using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamacyManagementSystem
{
    public partial class PharmacyForm2 : Form
    {
        public PharmacyForm2()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            phadashboard ad = new phadashboard();
            ad.ShowDialog();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            ModifyMedicine mm = new ModifyMedicine();
            mm.ShowDialog();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine ad = new AddMedicine();
            ad.ShowDialog();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicine vm = new ViewMedicine();
            vm.ShowDialog();
        }

        private void btnValidityCheck_Click(object sender, EventArgs e)
        {
            //MediValidity mv = new MediValidity();
            //mv.ShowDialog();
        }

        private void btnSellMedi_Click(object sender, EventArgs e)
        {
            SellMedicine sm = new SellMedicine();
            sm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutMedi am = new AboutMedi();
            am.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.YellowGreen;
            btnDashboard.IconColor = Color.YellowGreen;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconColor = Color.White;
        }

        private void btnAddMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnAddMedicine.ForeColor = Color.DarkBlue;
            btnAddMedicine.IconColor = Color.DarkBlue;
        }

        private void btnAddMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnAddMedicine.ForeColor = Color.White;
            btnAddMedicine.IconColor = Color.White;
        }

        private void btnViewMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnViewMedicine.ForeColor = Color.ForestGreen;
            btnViewMedicine.IconColor = Color.ForestGreen;
        }

        private void btnViewMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnViewMedicine.ForeColor = Color.White;
            btnViewMedicine.IconColor = Color.White;
        }

        private void btnModifyMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnModifyMedicine.ForeColor = Color.Black;
            btnModifyMedicine.IconColor = Color.Black;
        }

        private void btnModifyMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnModifyMedicine.ForeColor = Color.White;
            btnModifyMedicine.IconColor = Color.White;
        }

        private void btnSellMedi_MouseEnter(object sender, EventArgs e)
        {
            btnSellMedi.ForeColor = Color.DarkTurquoise;
            btnSellMedi.IconColor = Color.DarkTurquoise;
        }

        private void btnSellMedi_MouseLeave(object sender, EventArgs e)
        {
            btnSellMedi.ForeColor = Color.White;
            btnSellMedi.IconColor = Color.White;
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Maroon;
            btnAbout.IconColor = Color.Maroon;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.White;
            btnAbout.IconColor = Color.White;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.DarkOrange;
            btnLogout.IconColor = Color.DarkOrange;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
            btnLogout.IconColor = Color.White;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
