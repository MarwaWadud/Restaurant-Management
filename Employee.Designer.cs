
namespace WFAProject
{
    partial class Employee
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
            this.pnlECFull = new System.Windows.Forms.Panel();
            this.txtChartRole = new System.Windows.Forms.TextBox();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.btnChartSave = new System.Windows.Forms.Button();
            this.dgvEmployeeChart = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmployeeClose = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.txtChartSalary = new System.Windows.Forms.TextBox();
            this.txtChartName = new System.Windows.Forms.TextBox();
            this.txtChartID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblEmployeeChart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlECFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlECFull
            // 
            this.pnlECFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlECFull.Controls.Add(this.txtChartRole);
            this.pnlECFull.Controls.Add(this.lblEmployeeRole);
            this.pnlECFull.Controls.Add(this.btnChartSave);
            this.pnlECFull.Controls.Add(this.dgvEmployeeChart);
            this.pnlECFull.Controls.Add(this.btnEmployeeClose);
            this.pnlECFull.Controls.Add(this.btnEmployeeDelete);
            this.pnlECFull.Controls.Add(this.txtChartSalary);
            this.pnlECFull.Controls.Add(this.txtChartName);
            this.pnlECFull.Controls.Add(this.txtChartID);
            this.pnlECFull.Controls.Add(this.lblEmployeeID);
            this.pnlECFull.Controls.Add(this.lblEmployeeName);
            this.pnlECFull.Controls.Add(this.lblEmployeeSalary);
            this.pnlECFull.Controls.Add(this.lblEmployeeChart);
            this.pnlECFull.Location = new System.Drawing.Point(29, 38);
            this.pnlECFull.Name = "pnlECFull";
            this.pnlECFull.Size = new System.Drawing.Size(691, 417);
            this.pnlECFull.TabIndex = 1;
            // 
            // txtChartRole
            // 
            this.txtChartRole.Location = new System.Drawing.Point(90, 198);
            this.txtChartRole.Name = "txtChartRole";
            this.txtChartRole.Size = new System.Drawing.Size(100, 20);
            this.txtChartRole.TabIndex = 19;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRole.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeRole.Location = new System.Drawing.Point(23, 196);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(46, 20);
            this.lblEmployeeRole.TabIndex = 18;
            this.lblEmployeeRole.Text = "Role";
            // 
            // btnChartSave
            // 
            this.btnChartSave.BackColor = System.Drawing.Color.Red;
            this.btnChartSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChartSave.Location = new System.Drawing.Point(27, 296);
            this.btnChartSave.Name = "btnChartSave";
            this.btnChartSave.Size = new System.Drawing.Size(163, 26);
            this.btnChartSave.TabIndex = 16;
            this.btnChartSave.Text = "SAVE";
            this.btnChartSave.UseVisualStyleBackColor = false;
            this.btnChartSave.Click += new System.EventHandler(this.btnChartSave_Click);
            // 
            // dgvEmployeeChart
            // 
            this.dgvEmployeeChart.AllowUserToAddRows = false;
            this.dgvEmployeeChart.AllowUserToDeleteRows = false;
            this.dgvEmployeeChart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeChart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvEmployeeChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FoodName,
            this.Role,
            this.Salary});
            this.dgvEmployeeChart.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmployeeChart.Location = new System.Drawing.Point(211, 103);
            this.dgvEmployeeChart.Name = "dgvEmployeeChart";
            this.dgvEmployeeChart.ReadOnly = true;
            this.dgvEmployeeChart.RowHeadersVisible = false;
            this.dgvEmployeeChart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeChart.Size = new System.Drawing.Size(430, 288);
            this.dgvEmployeeChart.TabIndex = 15;
            this.dgvEmployeeChart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeChart_CellContentClick);
            this.dgvEmployeeChart.DoubleClick += new System.EventHandler(this.dgvEmployeeChart_DoubleClick);
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
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // btnEmployeeClose
            // 
            this.btnEmployeeClose.ForeColor = System.Drawing.Color.Red;
            this.btnEmployeeClose.Location = new System.Drawing.Point(619, 3);
            this.btnEmployeeClose.Name = "btnEmployeeClose";
            this.btnEmployeeClose.Size = new System.Drawing.Size(38, 23);
            this.btnEmployeeClose.TabIndex = 11;
            this.btnEmployeeClose.Text = "X";
            this.btnEmployeeClose.UseVisualStyleBackColor = true;
            this.btnEmployeeClose.Click += new System.EventHandler(this.btnEmployeeClose_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.Red;
            this.btnEmployeeDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeDelete.Location = new System.Drawing.Point(27, 346);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(163, 26);
            this.btnEmployeeDelete.TabIndex = 8;
            this.btnEmployeeDelete.Text = "DELETE";
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // txtChartSalary
            // 
            this.txtChartSalary.Location = new System.Drawing.Point(90, 238);
            this.txtChartSalary.Name = "txtChartSalary";
            this.txtChartSalary.Size = new System.Drawing.Size(100, 20);
            this.txtChartSalary.TabIndex = 6;
            // 
            // txtChartName
            // 
            this.txtChartName.Location = new System.Drawing.Point(90, 160);
            this.txtChartName.Name = "txtChartName";
            this.txtChartName.Size = new System.Drawing.Size(100, 20);
            this.txtChartName.TabIndex = 5;
            // 
            // txtChartID
            // 
            this.txtChartID.Location = new System.Drawing.Point(90, 125);
            this.txtChartID.Name = "txtChartID";
            this.txtChartID.Size = new System.Drawing.Size(100, 20);
            this.txtChartID.TabIndex = 4;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeID.Location = new System.Drawing.Point(23, 125);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(28, 20);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "ID";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeName.Location = new System.Drawing.Point(23, 158);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(55, 20);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalary.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(19, 236);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(59, 20);
            this.lblEmployeeSalary.TabIndex = 1;
            this.lblEmployeeSalary.Text = "Salary";
            // 
            // lblEmployeeChart
            // 
            this.lblEmployeeChart.AutoSize = true;
            this.lblEmployeeChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeChart.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeChart.Location = new System.Drawing.Point(309, 22);
            this.lblEmployeeChart.Name = "lblEmployeeChart";
            this.lblEmployeeChart.Size = new System.Drawing.Size(199, 29);
            this.lblEmployeeChart.TabIndex = 0;
            this.lblEmployeeChart.Text = "Employee Chart";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 417);
            this.panel1.TabIndex = 0;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(766, 491);
            this.Controls.Add(this.pnlECFull);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.pnlECFull.ResumeLayout(false);
            this.pnlECFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlECFull;
        private System.Windows.Forms.TextBox txtChartRole;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.Button btnChartSave;
        private System.Windows.Forms.DataGridView dgvEmployeeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btnEmployeeClose;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.TextBox txtChartSalary;
        private System.Windows.Forms.TextBox txtChartName;
        private System.Windows.Forms.TextBox txtChartID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeChart;
        private System.Windows.Forms.Panel panel1;
    }
}