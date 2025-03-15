using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace Payroll
{
    public partial class EmployeeDetails : Form
    {
        private Employee _employee;

        public object backpage;




        public EmployeeDetails(DataGridViewSelectedRowCollection selectedRows, object back)
        {

            backpage = back;
            InitializeComponent();
            if (selectedRows.Count > 0)
            {


                bool onPension = false; // Default value

                //get OnPension as a bool
                if (selectedRows[0].Cells["emp_OnPension"].Value != null)
                {
                    object cellValue = selectedRows[0].Cells["emp_OnPension"].Value;

                    if (cellValue is bool boolValue)
                    {
                        onPension = boolValue; // Directly assign if it's already a boolean
                    }
                    {
                        string stringValue = cellValue.ToString().Trim(); // Normalize input
                        if (stringValue == "Y" || stringValue == "y" || stringValue == 1.ToString())
                            onPension = true;
                        else if (stringValue == "N" || stringValue == "n" || stringValue == 0.ToString())
                            onPension = false;
                    }
                }

                DataGridViewRow row = selectedRows[0]; // Assuming single-row selection
                _employee = new Employee(
                    Convert.ToInt32(row.Cells["emp_EmployeeID"].Value),
                    row.Cells["emp_Title"].Value?.ToString() ?? "",
                    row.Cells["emp_FirstName"].Value?.ToString() ?? "",
                    row.Cells["emp_LastName"].Value?.ToString() ?? "",
                    row.Cells["emp_Email"].Value?.ToString() ?? "",
                    row.Cells["emp_Phone"].Value?.ToString() ?? "",
                    row.Cells["emp_AddressLine1"].Value?.ToString() ?? "",
                    row.Cells["emp_AddressLine2"].Value?.ToString() ?? "",
                    row.Cells["emp_Town"].Value?.ToString() ?? "",
                    row.Cells["emp_City"].Value?.ToString() ?? "",
                    row.Cells["emp_County"].Value?.ToString() ?? "",
                    row.Cells["emp_Postcode"].Value?.ToString() ?? "",
                    row.Cells["emp_TaxCode"].Value?.ToString() ?? "",
                    row.Cells["emp_HourlyRate"].Value?.ToString() ?? "",
                    row.Cells["emp_NINumber"].Value?.ToString() ?? "",
                    onPension,
                    row.Cells["emp_StudentLoanPlan"].Value?.ToString() ?? "",
                    row.Cells["emp_SortCode"].Value?.ToString() ?? "",
                    row.Cells["emp_AccountNumber"].Value?.ToString() ?? "",
                    row.Cells["emp_Notes"].Value?.ToString() ?? ""
                );


                PopulateFields();
            }
            else if (selectedRows == null || selectedRows.Count == 0)
            {
                MessageBox.Show("No row selected!");
                return;
            }
        }

        public EmployeeDetails(object back)
        {
            backpage = back;
            InitializeComponent();
        }

        private void PopulateFields()
        {
            txtID.Text = _employee.EmployeeID.ToString();
            txtTitle.Text = _employee.Title;
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone;
            txtAddress1.Text = _employee.AddressLine1;
            txtAddress2.Text = _employee.AddressLine2;
            txtTown.Text = _employee.Town;
            txtCity.Text = _employee.City;
            txtCounty.Text = _employee.County;
            txtPostCode.Text = _employee.PostCode;
            txtTaxCode.Text = _employee.TaxCode;
            txtRate.Text = _employee.HourlyRate;
            txtNINumber.Text = _employee.NINumber;
            chkPension.Checked = _employee.OnPension;
            txtStudentPlan.Text = _employee.StudentLoanPlan;
            txtSortCode.Text = _employee.SortCode;
            txtAccNum.Text = _employee.AccountNumber;
        }


        public DataGridViewSelectedRowCollection SelectedRows { get; }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            #region validate the details
            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();
                int chkID;
                if (!int.TryParse(txtID.Text, out chkID))
                {
                    MessageBox.Show("Error: Invalid Employee ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var parameters = new
                {
                    ID = chkID,
                    title = (txtTitle.Text ?? ""),
                    firstname = (txtFirstName.Text ?? ""),
                    lastname = (txtLastName.Text ?? ""),
                    email = (txtEmail.Text ?? ""),
                    phone = (txtPhone.Text ?? ""),
                    address1 = (txtAddress1.Text ?? ""),
                    address2 = (txtAddress2.Text ?? ""),
                    town = (txtTown.Text ?? ""),
                    city = (txtCity.Text ?? ""),
                    county = (txtCounty.Text ?? ""),
                    postcode = (txtPostCode.Text ?? ""),
                    taxcode = (txtTaxCode.Text ?? ""),
                    rate = decimal.TryParse(txtRate.Text, out decimal parsedRate) ? parsedRate : 0,
                    niNumber = (txtNINumber.Text ?? ""),
                    pension = chkPension.Checked,
                    studentPlan = (txtStudentPlan.Text ?? ""),
                    sortCode = (txtSortCode.Text ?? ""),
                    accountNumber = (txtAccNum.Text ?? "")
                };

                // dont need to validate notes
                string msg = conn.QueryFirstOrDefault<string>(
                "SELECT ValidateEmployeeData(@ID, @Title, @FirstName, @LastName, @Email, @Phone, @Address1, @Address2, @Town, @City, @County, @Postcode, @Taxcode, @Rate, @NiNumber, @Pension, @StudentPlan, @SortCode, @AccountNumber);",
                parameters
                );

                if (!string.IsNullOrWhiteSpace(msg))
                {
                    MessageBox.Show($"Validation Error: {msg}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            };
                #endregion

         #region Import into DB

            int ID = int.Parse(txtID.Text);
            string title = (txtTitle.Text ?? "");
            string firstname = (txtFirstName.Text ?? "");
            string lastname = (txtLastName.Text ?? "");
            string email = (txtEmail.Text ?? "");
            string phone = (txtPhone.Text ?? "");
            string address1 = (txtAddress1.Text ?? "");
            string address2 = (txtAddress2.Text ?? "");
            string town = (txtTown.Text ?? "");
            string city = (txtCity.Text ?? "");
            string county = (txtCounty.Text ?? "");
            string postcode = (txtPostCode.Text ?? "");
            string taxcode = (txtTaxCode.Text ?? "");
            string hourlyrate = (txtRate.Text ?? "");
            string niNumber = (txtNINumber.Text ?? "");
            bool pension = chkPension.Checked == true;
            string studentPlan = (txtStudentPlan.Text ?? "");
            string sortCode = (txtSortCode.Text ?? "");
            string accountNumber = (txtAccNum.Text ?? "");
            string availability = (txtAvailability.Text ?? "");



            using (MySqlConnection conn = new MySqlConnection(GloballyAvailable.conn))
            {
                conn.Open();

                //learning curve.. MySQL compared to SSMS
                string query = @"
                                INSERT INTO EmployeeData 
                                    (emp_EmployeeID, emp_Title, emp_FirstName, emp_LastName, emp_Email, emp_Phone, emp_AddressLine1, emp_AddressLine2, emp_Town, emp_City, emp_County, emp_Postcode, emp_TaxCode, emp_HourlyRate, emp_NINumber, emp_OnPension, emp_StudentLoanPlan, emp_SortCode, emp_AccountNumber, emp_Notes)
                                VALUES 
                                    (@ID, @Title, @FirstName, @LastName, @Email, @Phone, @Address1, @Address2, @Town, @City, @County, @Postcode, @TaxCode, @HourlyRate, @NiNumber, @Pension, @StudentPlan, @SortCode, @AccountNumber, @AvailabilityNotes)
                                ON DUPLICATE KEY UPDATE
                                    emp_Title = @Title, 
                                    emp_FirstName = @FirstName, 
                                    emp_LastName = @LastName, 
                                    emp_Email = @Email, 
                                    emp_Phone = @Phone, 
                                    emp_AddressLine1 = @Address1, 
                                    emp_AddressLine2 = @Address2, 
                                    emp_Town = @Town, 
                                    emp_City = @City, 
                                    emp_County = @County, 
                                    emp_Postcode = @Postcode, 
                                    emp_TaxCode = @TaxCode, 
                                    emp_HourlyRate = @HourlyRate, 
                                    emp_NINumber = @NiNumber, 
                                    emp_OnPension = @Pension, 
                                    emp_StudentLoanPlan = @StudentPlan, 
                                    emp_SortCode = @SortCode, 
                                    emp_AccountNumber = @AccountNumber,
                                    emp_Notes = @AvailabilityNotes
                            ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address1", address1);
                    cmd.Parameters.AddWithValue("@Address2", address2);
                    cmd.Parameters.AddWithValue("@Town", town);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@County", county);
                    cmd.Parameters.AddWithValue("@Postcode", postcode);
                    cmd.Parameters.AddWithValue("@TaxCode", taxcode);
                    cmd.Parameters.AddWithValue("@HourlyRate", hourlyrate);
                    cmd.Parameters.AddWithValue("@NiNumber", niNumber);
                    cmd.Parameters.AddWithValue("@Pension", pension);
                    cmd.Parameters.AddWithValue("@StudentPlan", studentPlan);
                    cmd.Parameters.AddWithValue("@SortCode", sortCode);
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.AddWithValue("@AvailabilityNotes", availability);
                    //dont need to validate notes..

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Employee record saved successfully!" : "No changes were made.");

                    this.Hide();
                    if (backpage is EmployeeList)
                    {
                        EmployeeList list = new EmployeeList();
                        list.Show();
                    }

                    if (backpage is Homepage)
                    {
                        Homepage hp = new Homepage();
                        hp.Show();
                    }
                }
            }
         #endregion
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (backpage is EmployeeList)
            {
                EmployeeList list = new EmployeeList();
                list.Show();
            }

            if (backpage is Homepage)
            {
                Homepage hp = new Homepage();
                hp.Show();
            }
        }

    }
    }

