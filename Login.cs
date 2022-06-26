using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                string sql = "select * from UsernameTable where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
                SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-BNDIGQL;Initial Catalog=RestaurantMangementSystem;Integrated Security=True");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {

                MessageBox.Show("Login Valid");
                if (ds.Tables[0].Rows[0][0].ToString() == "Manager")
                {
                    ChooseOption manager = new ChooseOption(this);
                    manager.Show();

                }
                else if (ds.Tables[0].Rows[0][0].ToString() == "Cashier")
                {
                    Extra cashier = new Extra(this);
                    cashier.Show();
                }
            }
          

            else
            {
                MessageBox.Show("Login Invalid");
               
            }



           sqlcon.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }


    }

}

