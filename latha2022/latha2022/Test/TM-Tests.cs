// See https://aka.ms/new-console-template for more information

using latha2022.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class TM_Tests
{
    static void Main(string[] args) 
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        // Login page object initialization and definition
        login_page loginpageobj = new Loginsteps();
        loginpageobj.Loginsteps(driver);
        
        //Home Page Object initialization and definition
        Home_page homepageobj = new Home_page();
        homepageobj.TMHomePage(driver);

        //Tm page object initilaztaion and definition
        Tm_page tmpageobj = new Tm_page();
        tmpageobj.MaterialDetails(driver);

        //Edit Material data
        tmpageobj.EditTm(driver);

        // Delete Materail data
        tmpageobj.DelTM(driver);
    }
}
    
   


