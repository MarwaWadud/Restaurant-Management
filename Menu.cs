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
    public partial class Menu : Form
    {
        private DataAccess Da { get; set; }
        //private ChooseOption Cn { get; set; }
        public Menu()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from FoodMenuTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = ds.Tables[0];
        }
        /*public Menu(ChooseOption m1) : this()
        {
            this.Cn = m1;
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidToSaveData())
                {
                    MessageBox.Show("Fill all the Informations.");
                    return;
                }

                var query = "select * from FoodMenuTable where ID ='" + this.txtMenuID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = "update FoodMenuTable set Name = '" + this.txtMenuName.Text + "', Price =  " + this.txtMenuPrice.Text + " where ID = '" + this.txtMenuID.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                else if (ds.Tables[0].Rows.Count == 0)
                {
                    var sql = @"insert into FoodMenuTable values ('" + this.txtMenuID.Text + "' , '" + this.txtMenuName.Text + "', " + this.txtMenuPrice.Text + ");";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data saved successfully.");
                    else
                        MessageBox.Show("Data saving failed.");
                }

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!" + exc.Message);
            }

        }

        private bool ValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtMenuID.Text) || String.IsNullOrEmpty(this.txtMenuName.Text) ||
                String.IsNullOrEmpty(this.txtMenuPrice.Text))
            {
                return true;
            }
            else
                return false;


        }

        private void dgvManager_DoubleClick(object sender, EventArgs e)
        {
            this.txtMenuID.Text = this.dgvManager.CurrentRow.Cells[0].Value.ToString();
            this.txtMenuName.Text = this.dgvManager.CurrentRow.Cells[1].Value.ToString();
            this.txtMenuPrice.Text = this.dgvManager.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var ID = this.dgvManager.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvManager.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from FoodMenuTable where ID = '" + ID + "';";

                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show(Name + " has been deleted.");
                else
                    MessageBox.Show("Failed to delete.");


                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!" + exc.Message);
            }
        }

        private void txtMenuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

