namespace Payroll
{
    partial class Schedule
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dbgEmployeeSchedule = new System.Windows.Forms.DataGridView();
            this.btnAddShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployeeSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(568, 1);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // dbgEmployeeSchedule
            // 
            this.dbgEmployeeSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgEmployeeSchedule.Location = new System.Drawing.Point(-10, 1);
            this.dbgEmployeeSchedule.Name = "dbgEmployeeSchedule";
            this.dbgEmployeeSchedule.Size = new System.Drawing.Size(577, 452);
            this.dbgEmployeeSchedule.TabIndex = 1;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(573, 410);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(105, 28);
            this.btnAddShift.TabIndex = 2;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.dbgEmployeeSchedule);
            this.Controls.Add(this.Calendar);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployeeSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView dbgEmployeeSchedule;
        private System.Windows.Forms.Button btnAddShift;
    }
}