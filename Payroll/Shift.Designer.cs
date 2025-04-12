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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtBreakMinutes = new System.Windows.Forms.TextBox();
            this.dbgSchedule = new System.Windows.Forms.DataGridView();
            this.dtpShiftStart = new System.Windows.Forms.DateTimePicker();
            this.dtpShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.btnSaveSchedule.Location = new System.Drawing.Point(551, 397);
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
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(549, 210);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(129, 20);
            this.txtTask.TabIndex = 6;
            // 
            // txtBreakMinutes
            // 
            this.txtBreakMinutes.Location = new System.Drawing.Point(549, 259);
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
            // dtpShiftStart
            // 
            this.dtpShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftStart.Location = new System.Drawing.Point(549, 119);
            this.dtpShiftStart.Name = "dtpShiftStart";
            this.dtpShiftStart.Size = new System.Drawing.Size(129, 20);
            this.dtpShiftStart.TabIndex = 9;
            // 
            // dtpShiftEnd
            // 
            this.dtpShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftEnd.Location = new System.Drawing.Point(549, 164);
            this.dtpShiftEnd.Name = "dtpShiftEnd";
            this.dtpShiftEnd.Size = new System.Drawing.Size(129, 20);
            this.dtpShiftEnd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Shift Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shift End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Task";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Break (minutes)";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpShiftEnd);
            this.Controls.Add(this.dtpShiftStart);
            this.Controls.Add(this.dbgSchedule);
            this.Controls.Add(this.txtBreakMinutes);
            this.Controls.Add(this.txtTask);
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
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtBreakMinutes;
        private System.Windows.Forms.DataGridView dbgSchedule;
        private System.Windows.Forms.DateTimePicker dtpShiftStart;
        private System.Windows.Forms.DateTimePicker dtpShiftEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}