namespace Payroll
{
    partial class Shift
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
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShiftStart = new System.Windows.Forms.TextBox();
            this.txtShiftEnd = new System.Windows.Forms.TextBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtBreakMinutes = new System.Windows.Forms.TextBox();
            this.dbgSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(549, 12);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 20);
            this.dtpShiftDate.TabIndex = 0;
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.Location = new System.Drawing.Point(689, 404);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSchedule.TabIndex = 1;
            this.btnSaveSchedule.Text = "Save Schedule";
            this.btnSaveSchedule.UseVisualStyleBackColor = true;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(549, 73);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(129, 21);
            this.cmbEmployees.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee";
            // 
            // txtShiftStart
            // 
            this.txtShiftStart.Location = new System.Drawing.Point(549, 129);
            this.txtShiftStart.Name = "txtShiftStart";
            this.txtShiftStart.Size = new System.Drawing.Size(129, 20);
            this.txtShiftStart.TabIndex = 4;
            // 
            // txtShiftEnd
            // 
            this.txtShiftEnd.Location = new System.Drawing.Point(549, 184);
            this.txtShiftEnd.Name = "txtShiftEnd";
            this.txtShiftEnd.Size = new System.Drawing.Size(129, 20);
            this.txtShiftEnd.TabIndex = 5;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(549, 231);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(129, 20);
            this.txtTask.TabIndex = 6;
            // 
            // txtBreakMinutes
            // 
            this.txtBreakMinutes.Location = new System.Drawing.Point(549, 281);
            this.txtBreakMinutes.Multiline = true;
            this.txtBreakMinutes.Name = "txtBreakMinutes";
            this.txtBreakMinutes.Size = new System.Drawing.Size(129, 20);
            this.txtBreakMinutes.TabIndex = 7;
            // 
            // dbgSchedule
            // 
            this.dbgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgSchedule.Location = new System.Drawing.Point(12, 12);
            this.dbgSchedule.Name = "dbgSchedule";
            this.dbgSchedule.Size = new System.Drawing.Size(489, 396);
            this.dbgSchedule.TabIndex = 8;
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbgSchedule);
            this.Controls.Add(this.txtBreakMinutes);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtShiftEnd);
            this.Controls.Add(this.txtShiftStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.dtpShiftDate);
            this.Name = "Shift";
            this.Text = "Shift";
            ((System.ComponentModel.ISupportInitialize)(this.dbgSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShiftStart;
        private System.Windows.Forms.TextBox txtShiftEnd;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtBreakMinutes;
        private System.Windows.Forms.DataGridView dbgSchedule;
    }
}