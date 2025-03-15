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
    public partial class Shift : Form
    {
        public Shift()
        {
            InitializeComponent();
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();
                string insertQuery = "INSERT INTO schedule " +
                                                            "(sch_ScheduleID,sch_EmployeeID,sch_ShiftDate,sch_TimeStart,sch_TimeEnd,sch_Task,sch_BreakMinutes) " +
                                                    "VALUES " +
                                                            "(@schID, @empID, @date, @start, @end, @task, @break)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@schID", "1");
                cmd.Parameters.AddWithValue("@empID", cmbEmployees.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpShiftDate.Value);
                cmd.Parameters.AddWithValue("@start", txtShiftStart.Text);
                cmd.Parameters.AddWithValue("@end", txtShiftEnd.Text);
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
                                FROM employeedata e
                                WHERE e.emp_EmployeeID NOT IN (
                                    SELECT sch_EmployeeID FROM schedule WHERE sch_ShiftDate = @shiftDate
                                )";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@shiftDate", selectedDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbgSchedule.DataSource = dt; // Bind to DataGridView
            }
        }
    }
}
