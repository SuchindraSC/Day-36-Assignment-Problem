using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    public class EmployeeDetails
    {
        public int EmployeeId;
        public string EmployeeName;
        public string PhoneNumber;
        public string Address;
        public string Department;
        public char Gender;
        public double BasicPay;
        public double Deductions;
        public double TaxablePay;
        public double Tax;
        public double NetPay;
        public string City;
        public string Country;

        public EmployeeDetails(int EmployeeId, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, double BasicPay,
            double Deductions, double TaxablePay, double Tax, double NetPay, string City, string Country)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
            this.City = City;
            this.Country = Country;
        }
    }
}
