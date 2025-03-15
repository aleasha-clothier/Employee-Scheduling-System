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
    public partial class Homepage : Form
    {
  
        public Homepage()
        {
            InitializeComponent();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeList EmployeeList = new EmployeeList();
            EmployeeList.Show();
            

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule Schedule = new Schedule();
            Schedule.Show();
        }
    }
}
