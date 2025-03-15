using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Payroll
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetails details = new EmployeeDetails(dbgEmployees.SelectedRows, this);
            details.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetails newEmp = new EmployeeDetails(this);
            newEmp.Show();
        }
    }
}
