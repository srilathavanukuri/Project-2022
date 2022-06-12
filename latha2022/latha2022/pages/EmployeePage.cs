using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.pages
{
    public class EmployeePage
    {
        public void createEmployee(IWebDriver driver)  
        {
            // click create button.
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(2000);

            //send text to name tesxt box
            driver.FindElement(By.Id("Name")).SendKeys("VIYAAN REDDY");
            Thread.Sleep(2000);

            //send to username text box
            driver.FindElement(By.Id("Username")).SendKeys("ViyaanReddy");
            Thread.Sleep(2000);

            //Identify edit contact button and click.
            driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button Clicked");
            Thread.Sleep(2000);

            //Navigate to pop window
            driver.SwitchTo().Frame(0);

            //Enter the details into contact textboxes
            driver.FindElement(By.Id("FirstName")).SendKeys("Viyaan");

            driver.FindElement(By.Id("LastName")).SendKeys("Reddy");

            driver.FindElement(By.Id("Phone")).SendKeys("0222333444");

            driver.FindElement(By.Id("Mobile")).SendKeys("0666777888");

            driver.FindElement(By.Id("email")).SendKeys("ViyaanReddy0607@gmail.com");

            driver.FindElement(By.Id("Fax")).SendKeys("1234567");

            Thread.Sleep(2000);

            //Enter Adress
            driver.FindElement(By.Id("Street")).SendKeys("12 Martin Square");

            driver.FindElement(By.Id("City")).SendKeys("wellinton");

            driver.FindElement(By.Id("Postcode")).SendKeys("6011");

            driver.FindElement(By.Id("Country")).SendKeys("NewZealand");

            Thread.Sleep(2000);

            // Identify save button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Save");
            Thread.Sleep(2000);

            // Swich back to window
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            // Send text to password textbox
            driver.FindElement(By.Id("Password")).SendKeys("Viyaan@0607");
            Thread.Sleep(2000);

            // Send text to Retypepassword textbox
            driver.FindElement(By.Id("RetypePassword")).SendKeys("Viyaan@0607");
            Thread.Sleep(2000);

            // Click IsAdmin
            driver.FindElement(By.Id("IsAdmin")).Click();
            Thread.Sleep(3000);

            // Select vehile textbox enter vehile information
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input")).
            SendKeys("Brand:Tesla,Colour:Red");
            Thread.Sleep(3000);

            // Select Groups Text drop down and click
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]")).Click();
            Thread.Sleep(3000);

            // Select from the Groups options and click
            driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[1]")).Click();
            Thread.Sleep(2000);

            // Identify save button and click
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            // Identify back to list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();
            Thread.Sleep(2000);

            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // Identify the new employee record created successfuly
            IWebElement newNameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[4]/td[1]"));

            IWebElement UserNameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[4]/td[2]"));

            // Assert 2
            
           Assert.That(newNameTextBox.Text == "VIYAAN REDDY"," Actual record and expected record do not match.");
            Assert.That(UserNameTextBox.Text == "ViyaanReddy", " Actual record and expected record do not match.");
        }
        public void EditEmpoloyee(IWebDriver driver) 
        {
            Thread.Sleep(2000);
            //Identify last page button and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            //Identifying created record and click on edit button
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[4]/td[3]/a[1]")).Click();
            Thread.Sleep(2000);

            // Edit text to Name text
            IWebElement editNameBox = driver.FindElement(By.Id("Name"));
            editNameBox.Clear();
            editNameBox.SendKeys("Viyaan");
            Thread.Sleep(2000);

            // edit text to Username text
            IWebElement editUserNameBox = driver.FindElement(By.Id("Username"));
            editUserNameBox.Clear();
            editUserNameBox.SendKeys("Viyaan");
            Thread.Sleep(2000);

            // Identify edit contact button and Click
            driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button Clicked");
            Thread.Sleep(2000);

            // Navigate pop window 
            driver.SwitchTo().Frame(0);
            //Enter the edit details into contact test box
            IWebElement editfirstnameBox = driver.FindElement(By.Id("FirstName"));
            editfirstnameBox.Clear();
            editfirstnameBox.Click();
            editfirstnameBox.SendKeys("Satish");

            IWebElement editLastNameBox = driver.FindElement(By.Id("LastName"));
            editLastNameBox.Click();
            editLastNameBox.Clear();
            editLastNameBox.SendKeys("Edited");

            IWebElement editPerferedNameBox = driver.FindElement(By.Id("PreferedName"));
            editPerferedNameBox.Click();
            editPerferedNameBox.SendKeys("Satish");


            IWebElement editPhoneNumberBox = driver.FindElement(By.Id("Phone"));
            editPhoneNumberBox.Click();
            editPhoneNumberBox.Clear();
            editPhoneNumberBox.SendKeys("0280419899");


            IWebElement editMobileBox = driver.FindElement(By.Id("Mobile"));
            editMobileBox.Click();
            editMobileBox.Clear();
            editMobileBox.SendKeys("0607201999");


            IWebElement editMailBox = driver.FindElement(By.Id("email"));
            editMailBox.Click();
            editMailBox.Clear();
            editMailBox.SendKeys("SatishReddy123@gmail.com");


            IWebElement editFaxBox = driver.FindElement(By.Id("Fax"));
            editFaxBox.Click();
            editFaxBox.Clear();
            editFaxBox.SendKeys("6542301");

            Thread.Sleep(2000);
            //Edit Adress

            IWebElement editStreetBox = driver.FindElement(By.Id("Street"));
            editStreetBox.Click();
            editStreetBox.Clear();
            editStreetBox.SendKeys("Wills street");


            IWebElement editCityBox = driver.FindElement(By.Id("City"));
            editCityBox.Click();
            editCityBox.Clear();    
            editCityBox.SendKeys("Auckland");


            IWebElement editPinCodeBox = driver.FindElement(By.Id("Postcode"));
            editPinCodeBox.Click();
            editPinCodeBox.Clear();
            editPinCodeBox.SendKeys("0600");


            IWebElement editCountryBox = driver.FindElement(By.Id("Country"));
            editCountryBox.Click();
            editCountryBox.Clear();
            editCountryBox.SendKeys("India");

            Thread.Sleep(2000);
            // Identify save Button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Saved");

            Thread.Sleep(2000);
            //Swith back to window
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            //Edit text to password textBox
            IWebElement editPasswordBox = driver.FindElement(By.Id("Password"));
            editPasswordBox.Click();
            editPasswordBox.Clear();
            editPasswordBox.SendKeys("Sati0428#");

            Thread.Sleep(2000);
            //Edit tect To Retype password
            IWebElement editRetypePassword = driver.FindElement(By.Id("RetypePassword"));
            editRetypePassword.Click();
            editRetypePassword.Clear();
            editRetypePassword.SendKeys("Sati0428#");

            Thread.Sleep(3000);
            //select vehicle textbox enter vehicle information
            IWebElement editVehicleTextBox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            editVehicleTextBox.Click();
            editVehicleTextBox.Clear();
            editVehicleTextBox.SendKeys("Brand:Audi, Colour:Grey");

            Thread.Sleep(2000);
            //Identify save Button and Click
            driver.FindElement(By.Id("SaveButton")).Click();

            //Identify back yo list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();

            Thread.Sleep(2000);
            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            //Identify edited employee record created successfully
            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[4]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[4]/td[2]"));

            //Assert 2
            Assert.That(editedName.Text == "Viyaan", " Actual record and expected record do not match.");
            Assert.That(editedUserName.Text == "Viyaan", " Actual record and expected record do not match.");

        }
        public void DeleteEmployee(IWebDriver driver) 
        {
            //Identify last pagebutton and click
            Thread.Sleep(1000);
            IWebElement lastpageButton = driver.FindElement(By.XPath(" //*[@id='usersGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(1000);

            //Identify delele button and click
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            lastRecord.Click();

            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Ok button clicked");
            Thread.Sleep(3000);

            // Identify Refresh button
            IWebElement refreshButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[5]/span"));
            refreshButton.Click();
            Thread.Sleep(2000);

            //Check the edited record is deleted
           IWebElement thelastrecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
           Thread.Sleep(2000);

            //Asserstion
            Assert.That(thelastrecord.Text != "Viyaan", "Employee record as not been deleted successfully ");

        }
    }
}
