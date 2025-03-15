using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Dapper;


namespace Payroll
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string TaxCode { get; set; }
        public string HourlyRate {  get; set; }
        public string NINumber { get; set; }
        public bool OnPension {  get; set; }
        public string StudentLoanPlan { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string AvailabilityNotes { get; set; }

        public Employee(int ID, string title, string firstName, string lastName, string email, string phone,
                         string addressLine1, string addressLine2, string town, string city, string county,
                         string postCode, string taxCode, string hourlyRate, string niNumber, bool onPension,
                         string studentLoanPlan, string sortCode, string accountNumber, string notes)
        {
            EmployeeID = ID;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Town = town;
            City = city;
            County = county;
            PostCode = postCode;
            TaxCode = taxCode;
            HourlyRate = hourlyRate;
            NINumber = niNumber;
            OnPension = onPension;
            StudentLoanPlan = studentLoanPlan;
            SortCode = sortCode;
            AccountNumber = accountNumber;
            AvailabilityNotes = notes;
        }


    }


}
