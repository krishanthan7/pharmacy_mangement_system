using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace PhamacyManagementSystem
{
    public partial class Form1 : Form
    {
        public static MySqlConnection connection; //st form

        public Form1()
        {
            InitializeComponent();

            try
            {
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "127.0.0.1";
                sb.Port = 3306;
                sb.UserID = "root";
                sb.Password = "";
                sb.Database = "pharmacy";

                connection = new MySqlConnection(sb.ToString());
                connection.Open();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            

            
        }

        private String getUserNameFromDB(String id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM users WHERE id=@id;", Form1.connection);
            cmd.Parameters.AddWithValue("@id", id);

            String name = "";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                name = rdr[0].ToString();
            }
            rdr.Close();

            return name;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // String name = getUserNameFromDB("22");
            // String name = getUserNameFromDB("22");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.White;
            btnSignIn.ForeColor = Color.FromArgb(31, 30, 68);
            
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.FromArgb(31,30, 68);
            btnSignIn.ForeColor = Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.FromArgb(31, 30, 68);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(31, 30, 68);
            btnReset.ForeColor = Color.White;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

                  
           MySqlCommand cmd = new MySqlCommand("SELECT user_role, name FROM user where username = @name AND password = @pass", Form1.connection);
           cmd.Parameters.AddWithValue("@name", txtUserName.Text);
           cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

           String role = "";
           String name = "";
           MySqlDataReader rdr = cmd.ExecuteReader();
           while (rdr.Read())
           {
               role = rdr[0].ToString();
               name = rdr[1].ToString();
           }
           rdr.Close();

            if (role == "Administrator")
            {
                Adminstrator am = new Adminstrator(name);
                am.Show();
                this.Hide();
                //rdr.Close();
            }

            else if (role == "Pharmacist")
            {
                PharmacyForm2 pf = new PharmacyForm2();
                pf.Show();
                this.Hide();
                //rdr.Close();
            }

            else
            {
                MessageBox.Show("Wrong User name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //rdr.Close();
            }








            /*
            if (txtUserName.Text == "Savitar" && txtPassword.Text == "2")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            }
            
           else
            if (txtUserName.Text == "p" && txtPassword.Text == "2")
            {
                PharmacyForm2 pf = new PharmacyForm2();
                pf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            */

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(31, 30, 68);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(31, 30, 68);
            btnExit.ForeColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}