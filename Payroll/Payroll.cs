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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=floodscape;database=dbo";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string sql = "SELECT * FROM EmployeeData";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dbgEmployees.DataSource = dt; // Assign DataTable to DataGridView
            }

        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayrollCalc pc = new PayrollCalc();
            pc.Show();
        }
    }

}
