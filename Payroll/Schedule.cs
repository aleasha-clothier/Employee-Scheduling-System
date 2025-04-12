using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Schedule : Form
    {
        public object ScheduleID { get; internal set; }
        public TimeSpan ShiftStart { get; internal set; }
        public TimeSpan ShiftEnd { get; internal set; }
        public string Task { get; internal set; }
        public int Break { get; internal set; }
        public object EmployeeID { get; internal set; }

        public Schedule()
        {
            InitializeComponent();
            LoadSchedule(DateTime.Today);
        }

        public Schedule(object scheduleID, TimeSpan shiftStart, TimeSpan shiftEnd,  string task, int breakm)
        {
            ScheduleID = scheduleID;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            Task = task;
            Break = breakm;
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = Calendar.SelectionStart;
            LoadSchedule(selectedDate);
        }

        private void LoadSchedule(DateTime selectedDate)
        {
            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();
          
                string query = @"
                    SELECT s.sch_ScheduleID, e.emp_FirstName, e.emp_LastName, s.sch_TimeStart, s.sch_TimeEnd, s.sch_Task, s.sch_BreakMinutes
                    FROM schedule s
                    JOIN employeedata e ON s.sch_EmployeeID = e.emp_EmployeeID
                    WHERE s.sch_ShiftDate = @shiftDate";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@shiftDate", selectedDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbgEmployeeSchedule.DataSource = dt; // Bind to DataGridView
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shift shift = new Shift(this);
            shift.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shift editShift = new Shift(dbgEmployeeSchedule.SelectedRows, this);
            editShift.Show();
        }
    }
}
