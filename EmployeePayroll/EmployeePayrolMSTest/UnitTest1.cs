using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;
using System.Collections.Generic;

namespace EmployeePayrolMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAdedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeDetails = new List<EmployeeDetails>();
            employeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "Bruce", PhoneNumber: "9999999999", Address: "xyz", Department: "bnv", Gender: "M", BasicPay: 2000000, Deductions: 200000, TaxablePay: 200000, Tax: 150000, NetPay: 1450000, City: "hjk", Country: "iouy"));
        }
    }
}
