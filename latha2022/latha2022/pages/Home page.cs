using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.pages
{
    public class Home_page

    {
        public void TMHomePage(IWebDriver driver) 
        {
            // Identify administration abd click
            IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Administration.Click();
            // select time & materials from dropdown list
            IWebElement tmOption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            tmOption.Click();
        }
    }
}


