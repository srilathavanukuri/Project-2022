using latha2022.pages;
using latha2022.utilites;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.Test
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : commonDriver
    {


        // page objects initialization
        Home_page homePageObj = new Home_page();
        EmployeePage employeePageObj = new EmployeePage();


        [Test, Order(1), Description("Create employee record with valid data ")]
        public void CreateEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.createEmployee(driver);
        }
        [Test, Order(2), Description("Edit employee record created in test number 1")]
        public void EditEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmpoloyee(driver);
        }

        [Test, Order(3), Description("Delete employee record created in test number 2")]
        public void DeleteEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);

        }
    }
}
