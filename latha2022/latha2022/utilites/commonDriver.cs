using latha2022.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.utilites
{
    public class commonDriver
    {
        public static IWebDriver driver;    
        login_page loginpageobj = new login_page();

        [OneTimeSetUp]
        public void LoingActions()
        {
            // open chrome browser
            driver = new ChromeDriver();


            // Login page object initialization and definition
            loginpageobj.Loginsteps(driver);
        }

        [OneTimeTearDown]
        public void ClosesTestRun()
        {
            driver.Quit();
        }
            


      
    }
}
