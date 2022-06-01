using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.pages 
{
public class login_page 
    {
    public void Loginsteps(IWebDriver driver)
        {
            // open chrome browser
           // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //lunch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // Identify user name and enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            // Identify password and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            // Identify log in button and click
            IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            login.Click();
            Thread.Sleep(1000);
            //check if user has logged successfully
            IWebElement helloHari = driver.FindElement(By.XPath(" //*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Successfully,test passed");
            }
            else
            {
                Console.WriteLine("Logged in failed,test failed");
            }
        }

       
    }
}