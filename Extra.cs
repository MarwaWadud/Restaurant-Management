using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFAProject
{
    public partial class Extra : Form
    {
        private Label lblBillPrice;
        private Button btnBillClose;
        private Label lblBillDate;
        private Panel panel3;
        private Button btnBillClear;
        private Button btnBillInsert;
        private TextBox txtBillQuantity;
        private TextBox txtBillPrice;
        private Label lblBillName;
        private Label lblBillQuantity;
        private Label lblBillID;
        private DateTimePicker txtBillDate;
        private Panel panel2;
        private Button btnPrint;
        private Label Bill;
        private DataGridView dgvBill;
        private TextBox txtBillID;
        private DataGridView dgvManager;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Price;
        private TextBox txtBillName;
        private TextBox txtBillAmount;
        private Button btnBillDelete;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private DataGridViewTextBoxColumn FoodID;
        private DataGridViewTextBoxColumn MenuFoodName;
        private DataGridViewTextBoxColumn FoodPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn total;
        private Panel panel1;

        private Login Fl { get; set; }

        private DataAccess Da { get; set; }
        public Extra()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        public Extra(Login fu) : this()
        {
            this.Fl = fu;
        }

        private void PopulateGridView(string sql = "select * from FoodMenuTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBillClose = new System.Windows.Forms.Button();
            this.txtBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBillName = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtBillQuantity = new System.Windows.Forms.TextBox();
            this.txtBillPrice = new System.Windows.Forms.TextBox();
            this.lblBillName = new System.Windows.Forms.Label();
            this.lblBillQuantity = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.btnBillClear = new System.Windows.Forms.Button();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.btnBillInsert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBillClose);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(269, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "BILLING SYSTEM";
            // 
            // btnBillClose
            // 
            this.btnBillClose.ForeColor = System.Drawing.Color.Red;
            this.btnBillClose.Location = new System.Drawing.Point(752, 4);
            this.btnBillClose.Name = "btnBillClose";
            this.btnBillClose.Size = new System.Drawing.Size(32, 23);
            this.btnBillClose.TabIndex = 5;
            this.btnBillClose.Text = "X";
            this.btnBillClose.UseVisualStyleBackColor = true;
            this.btnBillClose.Click += new System.EventHandler(this.btnBillClose_Click);
            // 
            // txtBillDate
            // 
            this.txtBillDate.Location = new System.Drawing.Point(559, 45);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(200, 20);
            this.txtBillDate.TabIndex = 6;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.ForeColor = System.Drawing.Color.Red;
            this.lblBillDate.Location = new System.Drawing.Point(641, 8);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(30, 13);
            this.lblBillDate.TabIndex = 2;
            this.lblBillDate.Text = "Date";
            // 
            // lblBillPrice
            // 
            this.lblBillPrice.AutoSize = true;
            this.lblBillPrice.ForeColor = System.Drawing.Color.Red;
            this.lblBillPrice.Location = new System.Drawing.Point(319, 8);
            this.lblBillPrice.Name = "lblBillPrice";
            this.lblBillPrice.Size = new System.Drawing.Size(31, 13);
            this.lblBillPrice.TabIndex = 1;
            this.lblBillPrice.Text = "Price";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBillName);
            this.panel3.Controls.Add(this.txtBillDate);
            this.panel3.Controls.Add(this.txtBillID);
            this.panel3.Controls.Add(this.lblBillDate);
            this.panel3.Controls.Add(this.txtBillQuantity);
            this.panel3.Controls.Add(this.txtBillPrice);
            this.panel3.Controls.Add(this.lblBillName);
            this.panel3.Controls.Add(this.lblBillPrice);
            this.panel3.Controls.Add(this.lblBillQuantity);
            this.panel3.Controls.Add(this.lblBillID);
            this.panel3.Location = new System.Drawing.Point(12, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 77);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtBillName
            // 
            this.txtBillName.Location = new System.Drawing.Point(150, 45);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(100, 20);
            this.txtBillName.TabIndex = 13;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(21, 45);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(100, 20);
            this.txtBillID.TabIndex = 11;
            // 
            // txtBillQuantity
            // 
            this.txtBillQuantity.Location = new System.Drawing.Point(420, 45);
            this.txtBillQuantity.Name = "txtBillQuantity";
            this.txtBillQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBillQuantity.TabIndex = 6;
            // 
            // txtBillPrice
            // 
            this.txtBillPrice.Location = new System.Drawing.Point(285, 45);
            this.txtBillPrice.Name = "txtBillPrice";
            this.txtBillPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBillPrice.TabIndex = 5;
            // 
            // lblBillName
            // 
            this.lblBillName.AutoSize = true;
            this.lblBillName.ForeColor = System.Drawing.Color.Red;
            this.lblBillName.Location = new System.Drawing.Point(184, 8);
            this.lblBillName.Name = "lblBillName";
            this.lblBillName.Size = new System.Drawing.Size(35, 13);
            this.lblBillName.TabIndex = 2;
            this.lblBillName.Text = "Name";
            // 
            // lblBillQuantity
            // 
            this.lblBillQuantity.AutoSize = true;
            this.lblBillQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblBillQuantity.Location = new System.Drawing.Point(449, 8);
            this.lblBillQuantity.Name = "lblBillQuantity";
            this.lblBillQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblBillQuantity.TabIndex = 1;
            this.lblBillQuantity.Text = "Quantity";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.ForeColor = System.Drawing.Color.Red;
            this.lblBillID.Location = new System.Drawing.Point(61, 8);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(18, 13);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "ID";
            // 
            // btnBillClear
            // 
            this.btnBillClear.BackColor = System.Drawing.Color.Red;
            this.btnBillClear.Location = new System.Drawing.Point(45, 62);
            this.btnBillClear.Name = "btnBillClear";
            this.btnBillClear.Size = new System.Drawing.Size(181, 23);
            this.btnBillClear.TabIndex = 9;
            this.btnBillClear.Text = "CLEAR";
            this.btnBillClear.UseVisualStyleBackColor = false;
            this.btnBillClear.Click += new System.EventHandler(this.btnBillClear_Click);
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.BackColor = System.Drawing.Color.Red;
            this.btnBillDelete.Location = new System.Drawing.Point(45, 29);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(181, 23);
            this.btnBillDelete.TabIndex = 8;
            this.btnBillDelete.Text = "DELETE";
            this.btnBillDelete.UseVisualStyleBackColor = false;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // btnBillInsert
            // 
            this.btnBillInsert.BackColor = System.Drawing.Color.Red;
            this.btnBillInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBillInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBillInsert.Location = new System.Drawing.Point(45, -1);
            this.btnBillInsert.Name = "btnBillInsert";
            this.btnBillInsert.Size = new System.Drawing.Size(181, 23);
            this.btnBillInsert.TabIndex = 7;
            this.btnBillInsert.Text = "INSERT";
            this.btnBillInsert.UseVisualStyleBackColor = false;
            this.btnBillInsert.Click += new System.EventHandler(this.btnBillInsert_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Controls.Add(this.btnBillClear);
            this.panel2.Controls.Add(this.btnBillInsert);
            this.panel2.Controls.Add(this.btnBillDelete);
            this.panel2.Location = new System.Drawing.Point(268, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 88);
            this.panel2.TabIndex = 18;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(388, 57);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(128, 20);
            this.txtBillAmount.TabIndex = 18;
            this.txtBillAmount.TextChanged += new System.EventHandler(this.txtBillAmount_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(272, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 74);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.ForeColor = System.Drawing.Color.Red;
            this.Bill.Location = new System.Drawing.Point(400, 18);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(86, 13);
            this.Bill.TabIndex = 13;
            this.Bill.Text = "Total Bill Amount";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodID,
            this.MenuFoodName,
            this.FoodPrice,
            this.Quantity,
            this.Amount,
            this.Date,
            this.total});
            this.dgvBill.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBill.Location = new System.Drawing.Point(268, 150);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(531, 238);
            this.dgvBill.TabIndex = 19;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // FoodID
            // 
            this.FoodID.DataPropertyName = "txtBillID";
            this.FoodID.FillWeight = 40.61421F;
            this.FoodID.HeaderText = "ID";
            this.FoodID.Name = "FoodID";
            // 
            // MenuFoodName
            // 
            this.MenuFoodName.DataPropertyName = "txtBillName";
            this.MenuFoodName.FillWeight = 82.13096F;
            this.MenuFoodName.HeaderText = "Name";
            this.MenuFoodName.Name = "MenuFoodName";
            // 
            // FoodPrice
            // 
            this.FoodPrice.DataPropertyName = "txtBillPrice";
            this.FoodPrice.FillWeight = 82.13096F;
            this.FoodPrice.HeaderText = "Price";
            this.FoodPrice.Name = "FoodPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "txtBillQuantity";
            this.Quantity.FillWeight = 82.13096F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.FillWeight = 82.13096F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "txtBillDate";
            this.Date.FillWeight = 248.7309F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // total
            // 
            this.total.FillWeight = 82.13096F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // dgvManager
            // 
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.AllowUserToDeleteRows = false;
            this.dgvManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FoodName,
            this.Price});
            this.dgvManager.Location = new System.Drawing.Point(12, 152);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersVisible = false;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(250, 331);
            this.dgvManager.TabIndex = 20;
            this.dgvManager.DoubleClick += new System.EventHandler(this.dgvManager_DoubleClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "Name";
            this.FoodName.HeaderText = "Name";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Extra
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(810, 507);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Extra";
            this.Load += new System.EventHandler(this.Extra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBillID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Extra_Load(object sender, EventArgs e)
        {

        }

        private void btnBillInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.ValidToSaveData())
                {
                    MessageBox.Show("Fill all the Informations.");
                    return;
                }

                else
                {
                    if (!this.ValidToSaveData())
                    {

                        int row = 0;
                        dgvBill.Rows.Add();
                        //row = dgvBill.Rows.Count - 1;
                        this.dgvBill.CurrentRow.Cells[0].Value = this.txtBillID.Text;
                        this.dgvBill.CurrentRow.Cells[1].Value = this.txtBillName.Text;
                        this.dgvBill.CurrentRow.Cells[2].Value = this.txtBillPrice.Text;
                        this.dgvBill.CurrentRow.Cells[3].Value = this.txtBillQuantity.Text;
                        this.dgvBill.CurrentRow.Cells[4].Value = Convert.ToInt32(txtBillPrice.Text) * Convert.ToInt32(txtBillQuantity.Text);
                        this.dgvBill.CurrentRow.Cells[5].Value = this.txtBillDate.Text;
                       


                       int sum = 0;
                        for (int i = 0; i < dgvBill.Rows.Count; ++i)
                        {
                            sum += Convert.ToInt32(dgvBill.Rows[i].Cells[4].Value);
                        }
                        txtBillAmount.Text = sum.ToString();
                        this.dgvBill.CurrentRow.Cells[6].Value = this.txtBillAmount.Text;


                        //total bill amount
                        //txtBillAmount.Text = this.dgvBill.CurrentRow.Cells.Count.ToString();

                        dgvBill.Refresh();
                        

                        if (dgvBill.Rows.Count > 0)
                        {
                            dgvBill.CurrentCell = dgvBill.Rows[dgvBill.Rows.Count - 1].Cells[1];
                        }



                    }


                   /* else
                    {

                        this.dgvBill.CurrentRow.Cells[0].Value = this.txtBillID.Text;
                        this.dgvBill.CurrentRow.Cells[1].Value = this.txtBillID.Text;
                        this.dgvBill.CurrentRow.Cells[2].Value = this.txtBillID.Text;
                        this.dgvBill.CurrentRow.Cells[3].Value = this.txtBillID.Text;


                        btnBillInsert.Text = "Add";
                    }*/

                }

            }


            catch (Exception exc)
            {
                MessageBox.Show("Error!" + exc.Message);
            }
        }

        private bool ValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtBillID.Text) || String.IsNullOrEmpty(this.txtBillName.Text) ||
                String.IsNullOrEmpty(this.txtBillPrice.Text) || String.IsNullOrEmpty(this.txtBillQuantity.Text))
            {
                return true;
            }
            else
                return false;


        }




        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvBill.CurrentCell.RowIndex;
            dgvBill.Rows.RemoveAt(rowIndex);
                

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnBillClear_Click(object sender, EventArgs e)
        {
            txtBillID.Text = "";
            txtBillName.Text = "";
            txtBillPrice.Text = "";
            txtBillQuantity.Text = "";

        }

        private void dgvManager_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtBillID.Text = this.dgvManager.CurrentRow.Cells[0].Value.ToString();
            this.txtBillName.Text = this.dgvManager.CurrentRow.Cells[1].Value.ToString();
            this.txtBillPrice.Text = this.dgvManager.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillAmount_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnBillClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           

        }

     




        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap objBmp = new Bitmap(this.dgvBill.Width, this.dgvBill.Height);
            dgvBill.DrawToBitmap(objBmp, new Rectangle (0, 0, this.dgvBill.Width, this.dgvBill.Height));
            e.Graphics.DrawImage(objBmp, 250, 120);
            e.Graphics.DrawString(Bill.Text, new Font("Image", 20, FontStyle.Bold), Brushes.Black, new Point(240, 60));

        }
    }

   
}
