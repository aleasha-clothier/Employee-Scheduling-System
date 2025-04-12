using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Payroll
{
    public partial class Shift : Form
    {
        public object backpage;
        private Schedule _schedule;
        public Shift(DataGridViewSelectedRowCollection selectedRows, object back)
        {

            InitializeComponent();
            backpage = back;
            LoadEmployees();

            if (selectedRows.Count > 0)
            {
                DataGridViewRow row = selectedRows[0]; // Assuming single-row selection
                _schedule = new Schedule(
                    Convert.ToInt32(row.Cells["sch_ScheduleID"].Value),               // Convert to int
                    TimeSpan.Parse(row.Cells["sch_TimeStart"].Value.ToString()),       // TimeStart as TimeSpan
                    TimeSpan.Parse(row.Cells["sch_TimeEnd"].Value.ToString()),         // TimeEnd as TimeSpan
                    row.Cells["sch_Task"].Value.ToString() ?? "",
                    Convert.ToInt32(row.Cells["sch_BreakMinutes"].Value));

                PopulateFields();
            }
            else if (selectedRows == null || selectedRows.Count == 0)
            {
                MessageBox.Show("No row selected!");
                return;
            }
        }

        public Shift(object back)
        {
            backpage = back;
            InitializeComponent();
            LoadEmployees();
        }

        public Shift()
        {
        }

        private void PopulateFields()
        {
            cmbEmployees.SelectedValue = _schedule.ScheduleID;
            dtpShiftStart.Value = DateTime.Parse(_schedule.ShiftStart.ToString());
            dtpShiftEnd.Value = DateTime.Parse(_schedule.ShiftEnd.ToString());
            txtTask.Text = _schedule.Task;
            txtBreakMinutes.Text = _schedule.Break.ToString();
        }


        public DataGridViewSelectedRowCollection SelectedRows { get; }
        private void LoadEmployees()
        {
            var conn = new MySqlConnection(GloballyAvailable.conn);
            string query = "SELECT emp_EmployeeID, emp_FirstName " +
                            "FROM employeedata ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbEmployees.DataSource = dt;
            cmbEmployees.DisplayMember = "emp_FirstName";
            cmbEmployees.ValueMember = "emp_EmployeeID";
        }
        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();
                string insertQuery = "INSERT INTO schedule " +
                                                            "(sch_EmployeeID,sch_ShiftDate,sch_TimeStart,sch_TimeEnd,sch_Task,sch_BreakMinutes) " +
                                                    "VALUES " +
                                                            "(@empID, @date, @start, @end, @task, @break) " +
                                      " ON DUPLICATE KEY UPDATE  " +
                                        "sch_ShiftDate = @date, " +
                                        "sch_TimeStart = @start, " +
                                        "sch_TimeEnd = @end, " +
                                        "sch_Task = @task, " + 
                                        "sch_BreakMinutes = @break";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@empID", cmbEmployees.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpShiftDate.Value);
                cmd.Parameters.AddWithValue("@start", dtpShiftStart.Value);
                cmd.Parameters.AddWithValue("@end", dtpShiftEnd.Value);
                cmd.Parameters.AddWithValue("@task", txtTask.Text);
                cmd.Parameters.AddWithValue("@break", int.Parse(txtBreakMinutes.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Shift Added Successfully!");
                LoadSchedule(dtpShiftDate.Value); // Refresh list
            }
        }
        private void LoadSchedule(DateTime selectedDate)
        {
            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();
                string query = @"
                                SELECT e.emp_EmployeeID, e.emp_FirstName, e.emp_LastName 
                                FROM dbo.employeedata e
                                WHERE e.emp_EmployeeID IN (
                                    SELECT sch_EmployeeID FROM dbo.schedule WHERE sch_ShiftDate = @shiftDate
                                )";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@shiftDate",selectedDate.Date );

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbgSchedule.DataSource = dt; // Bind to DataGridView
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEmpId = Convert.ToInt32(cmbEmployees.SelectedValue);
            MessageBox.Show("Selected Employee ID: " + selectedEmpId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (backpage is Schedule)
            {
                Schedule Schedule = new Schedule();
                Schedule.Show();
            }

            if (backpage is Homepage)
            {
                Homepage hp = new Homepage();
                hp.Show();
            }
        }
    }
}
