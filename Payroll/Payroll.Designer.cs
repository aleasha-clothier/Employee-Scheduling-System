namespace Payroll
{
    partial class Payroll
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dbgEmployees = new System.Windows.Forms.DataGridView();
            this.btnPayroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(590, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Home";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dbgEmployees
            // 
            this.dbgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgEmployees.Location = new System.Drawing.Point(25, 12);
            this.dbgEmployees.Name = "dbgEmployees";
            this.dbgEmployees.Size = new System.Drawing.Size(542, 426);
            this.dbgEmployees.TabIndex = 3;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Location = new System.Drawing.Point(690, 415);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(75, 23);
            this.btnPayroll.TabIndex = 4;
            this.btnPayroll.Text = "Edit Payroll";
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.dbgEmployees);
            this.Controls.Add(this.btnReturn);
            this.Name = "Payroll";
            this.Text = "Payroll";
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dbgEmployees;
        private System.Windows.Forms.Button btnPayroll;
    }
}