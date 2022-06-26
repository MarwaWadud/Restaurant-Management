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
    public partial class Employee : Form
    {
        private DataAccess Da { get; set; }
        //private Employee Nb { get; set; }
        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from EmployeeChart;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployeeChart.AutoGenerateColumns = false;
            this.dgvEmployeeChart.DataSource = ds.Tables[0];
        }



        private void btnEmployeeClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void dgvEmployeeChart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChartSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidToSaveData())
                {
                    MessageBox.Show("Fill all the Informations.");
                    return;
                }

                var query = "select * from EmployeeChart where ID ='" + this.txtChartID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = "update EmployeeChart set Name = '" + this.txtChartName.Text + "', Role = '" + this.txtChartRole.Text + "', Salary =  " + this.txtChartSalary.Text + " where ID = '" + this.txtChartID.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                else if (ds.Tables[0].Rows.Count == 0)
                {
                    var sql = @"insert into EmployeeChart values ('" + this.txtChartID.Text + "' , '" + this.txtChartName.Text + "', '" + this.txtChartRole.Text + "', " + this.txtChartSalary.Text + ");";
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
            if (String.IsNullOrEmpty(this.txtChartID.Text) || String.IsNullOrEmpty(this.txtChartName.Text) ||
                String.IsNullOrEmpty(this.txtChartRole.Text) || String.IsNullOrEmpty(this.txtChartSalary.Text))
            {
                return true;
            }
            else
                return false;


        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = this.dgvEmployeeChart.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvEmployeeChart.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from EmployeeChart where ID = '" + ID + "';";

                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show(ID + "has been deleted.");
                else
                    MessageBox.Show("Failed to delete.");


                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!" + exc.Message);
            }


        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployeeChart_DoubleClick(object sender, EventArgs e)
        {
            this.txtChartID.Text = this.dgvEmployeeChart.CurrentRow.Cells[0].Value.ToString();
            this.txtChartName.Text = this.dgvEmployeeChart.CurrentRow.Cells[1].Value.ToString();
            this.txtChartRole.Text = this.dgvEmployeeChart.CurrentRow.Cells[2].Value.ToString();
            this.txtChartSalary.Text = this.dgvEmployeeChart.CurrentRow.Cells[3].Value.ToString();
        }
    }

   
}
