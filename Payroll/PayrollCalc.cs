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
    public partial class PayrollCalc : Form
    {
        public PayrollCalc()
        {
            InitializeComponent();
        }

        /*
                SELECT 
                wh_EmployeeID,
                SUM(wh_HoursWorked) AS TotalHoursWorked,
                SUM(wh_SickDays) AS TotalSickDays,
                SUM(wh_HolidayTaken) AS TotalHolidayTaken,
                SUM(wh_EmergencyShifts) AS TotalEmergencyShifts
            FROM WorkedTime
            WHERE wh_EmployeeID = ID
              AND wh_ShiftDate BETWEEN period_start AND period_end
            GROUP BY wh_EmployeeID, period_start, period_end;
        */
    }
}
