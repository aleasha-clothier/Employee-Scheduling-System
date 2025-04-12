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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEditShift = new System.Windows.Forms.Button();
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
            this.dbgEmployeeSchedule.MultiSelect = false;
            this.dbgEmployeeSchedule.Name = "dbgEmployeeSchedule";
            this.dbgEmployeeSchedule.Size = new System.Drawing.Size(577, 452);
            this.dbgEmployeeSchedule.TabIndex = 1;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(573, 211);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(105, 28);
            this.btnAddShift.TabIndex = 2;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(698, 410);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 28);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Home";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditShift
            // 
            this.btnEditShift.Location = new System.Drawing.Point(690, 211);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(105, 28);
            this.btnEditShift.TabIndex = 4;
            this.btnEditShift.Text = "Edit Shift";
            this.btnEditShift.UseVisualStyleBackColor = true;
            this.btnEditShift.Click += new System.EventHandler(this.btnEditShift_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditShift);
            this.Controls.Add(this.btnReturn);
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditShift;
    }
}