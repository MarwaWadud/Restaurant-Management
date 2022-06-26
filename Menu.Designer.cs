
namespace WFAProject
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuFull = new System.Windows.Forms.Panel();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenuClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMenuSave = new System.Windows.Forms.Button();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtMenuID = new System.Windows.Forms.TextBox();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlMenuFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuFull
            // 
            this.pnlMenuFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMenuFull.Controls.Add(this.dgvManager);
            this.pnlMenuFull.Controls.Add(this.btnMenuClose);
            this.pnlMenuFull.Controls.Add(this.btnDelete);
            this.pnlMenuFull.Controls.Add(this.btnMenuSave);
            this.pnlMenuFull.Controls.Add(this.txtMenuPrice);
            this.pnlMenuFull.Controls.Add(this.txtMenuName);
            this.pnlMenuFull.Controls.Add(this.txtMenuID);
            this.pnlMenuFull.Controls.Add(this.lblFoodID);
            this.pnlMenuFull.Controls.Add(this.lblFoodName);
            this.pnlMenuFull.Controls.Add(this.lblFoodPrice);
            this.pnlMenuFull.Controls.Add(this.lblMenu);
            this.pnlMenuFull.Location = new System.Drawing.Point(23, 12);
            this.pnlMenuFull.Name = "pnlMenuFull";
            this.pnlMenuFull.Size = new System.Drawing.Size(668, 417);
            this.pnlMenuFull.TabIndex = 0;
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
            this.dgvManager.Location = new System.Drawing.Point(218, 93);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersVisible = false;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(430, 288);
            this.dgvManager.TabIndex = 14;
            this.dgvManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManager_CellContentClick);
            this.dgvManager.DoubleClick += new System.EventHandler(this.dgvManager_DoubleClick);
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
            // btnMenuClose
            // 
            this.btnMenuClose.ForeColor = System.Drawing.Color.Red;
            this.btnMenuClose.Location = new System.Drawing.Point(627, 3);
            this.btnMenuClose.Name = "btnMenuClose";
            this.btnMenuClose.Size = new System.Drawing.Size(38, 23);
            this.btnMenuClose.TabIndex = 12;
            this.btnMenuClose.Text = "X";
            this.btnMenuClose.UseVisualStyleBackColor = true;
            this.btnMenuClose.Click += new System.EventHandler(this.btnMenuClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(27, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMenuSave
            // 
            this.btnMenuSave.BackColor = System.Drawing.Color.Red;
            this.btnMenuSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuSave.Location = new System.Drawing.Point(27, 263);
            this.btnMenuSave.Name = "btnMenuSave";
            this.btnMenuSave.Size = new System.Drawing.Size(163, 26);
            this.btnMenuSave.TabIndex = 7;
            this.btnMenuSave.Text = "SAVE";
            this.btnMenuSave.UseVisualStyleBackColor = false;
            this.btnMenuSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(90, 208);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(100, 20);
            this.txtMenuPrice.TabIndex = 6;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(90, 163);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(100, 20);
            this.txtMenuName.TabIndex = 5;
            // 
            // txtMenuID
            // 
            this.txtMenuID.Location = new System.Drawing.Point(90, 114);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(100, 20);
            this.txtMenuID.TabIndex = 4;
            this.txtMenuID.TextChanged += new System.EventHandler(this.txtMenuID_TextChanged);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodID.ForeColor = System.Drawing.Color.Red;
            this.lblFoodID.Location = new System.Drawing.Point(23, 112);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(28, 20);
            this.lblFoodID.TabIndex = 3;
            this.lblFoodID.Text = "ID";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.Red;
            this.lblFoodName.Location = new System.Drawing.Point(23, 161);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(55, 20);
            this.lblFoodName.TabIndex = 2;
            this.lblFoodName.Text = "Name";
            this.lblFoodName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.Red;
            this.lblFoodPrice.Location = new System.Drawing.Point(23, 208);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(49, 20);
            this.lblFoodPrice.TabIndex = 1;
            this.lblFoodPrice.Text = "Price";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Red;
            this.lblMenu.Location = new System.Drawing.Point(309, 22);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(88, 29);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.pnlMenuFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenuFull.ResumeLayout(false);
            this.pnlMenuFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuFull;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMenuSave;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtMenuID;
        private System.Windows.Forms.Button btnMenuClose;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}