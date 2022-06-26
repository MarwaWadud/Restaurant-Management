using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProject
{
    public partial class ChooseOption : Form
    {
        private Login Fr { get; set; }
        public ChooseOption()
        {
            InitializeComponent();
        }

        public ChooseOption(Login f1) : this()
        {
            this.Fr = f1;
        }

        private void btnCOPClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptionEmployee_Click(object sender, EventArgs e)
        {

            this.Hide();
            Employee cashier = new Employee();
            cashier.Show();





        }

        private void btnOptionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu manager = new Menu();
            manager.Show();

        }

        private void ChooseOption_Load(object sender, EventArgs e)
        {

        }
    }
}
