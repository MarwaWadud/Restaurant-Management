
namespace WFAProject
{
    partial class ChooseOption
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCOPClose = new System.Windows.Forms.Button();
            this.btnOptionMenu = new System.Windows.Forms.Button();
            this.btnOptionEmployee = new System.Windows.Forms.Button();
            this.lblChooseOption = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnCOPClose);
            this.panel1.Controls.Add(this.btnOptionMenu);
            this.panel1.Controls.Add(this.btnOptionEmployee);
            this.panel1.Controls.Add(this.lblChooseOption);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 417);
            this.panel1.TabIndex = 0;
            // 
            // btnCOPClose
            // 
            this.btnCOPClose.ForeColor = System.Drawing.Color.Red;
            this.btnCOPClose.Location = new System.Drawing.Point(535, 3);
            this.btnCOPClose.Name = "btnCOPClose";
            this.btnCOPClose.Size = new System.Drawing.Size(38, 23);
            this.btnCOPClose.TabIndex = 3;
            this.btnCOPClose.Text = "X";
            this.btnCOPClose.UseVisualStyleBackColor = true;
            this.btnCOPClose.Click += new System.EventHandler(this.btnCOPClose_Click);
            // 
            // btnOptionMenu
            // 
            this.btnOptionMenu.BackColor = System.Drawing.Color.Red;
            this.btnOptionMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOptionMenu.Location = new System.Drawing.Point(173, 262);
            this.btnOptionMenu.Name = "btnOptionMenu";
            this.btnOptionMenu.Size = new System.Drawing.Size(199, 52);
            this.btnOptionMenu.TabIndex = 2;
            this.btnOptionMenu.Text = "Menu";
            this.btnOptionMenu.UseVisualStyleBackColor = false;
            this.btnOptionMenu.Click += new System.EventHandler(this.btnOptionMenu_Click);
            // 
            // btnOptionEmployee
            // 
            this.btnOptionEmployee.BackColor = System.Drawing.Color.Red;
            this.btnOptionEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOptionEmployee.Location = new System.Drawing.Point(173, 165);
            this.btnOptionEmployee.Name = "btnOptionEmployee";
            this.btnOptionEmployee.Size = new System.Drawing.Size(199, 52);
            this.btnOptionEmployee.TabIndex = 1;
            this.btnOptionEmployee.Text = "Employee Chart";
            this.btnOptionEmployee.UseVisualStyleBackColor = false;
            this.btnOptionEmployee.Click += new System.EventHandler(this.btnOptionEmployee_Click);
            // 
            // lblChooseOption
            // 
            this.lblChooseOption.AutoSize = true;
            this.lblChooseOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOption.ForeColor = System.Drawing.Color.Red;
            this.lblChooseOption.Location = new System.Drawing.Point(88, 86);
            this.lblChooseOption.Name = "lblChooseOption";
            this.lblChooseOption.Size = new System.Drawing.Size(388, 29);
            this.lblChooseOption.TabIndex = 0;
            this.lblChooseOption.Text = "CHOOSE OPTION TO CHANGE";
            this.lblChooseOption.UseWaitCursor = true;
            // 
            // ChooseOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseOption";
            this.Text = "ChooseOption";
            this.Load += new System.EventHandler(this.ChooseOption_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOptionMenu;
        private System.Windows.Forms.Button btnOptionEmployee;
        private System.Windows.Forms.Label lblChooseOption;
        private System.Windows.Forms.Button btnCOPClose;
    }
}