// See https://aka.ms/new-console-template for more information

using latha2022.pages;
using latha2022.utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class TM_Tests : commonDriver
{
    
        [SetUp]
    public void LoingActions()
    {
        // open chrome browser
         driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        // Login page object initialization and definition
        login_page loginpageobj = new Loginsteps();
        loginpageobj.Loginsteps(driver);

        //Home Page Object initialization and definition
        Home_page homepageobj = new Home_page();
        homepageobj.TMHomePage(driver);

    }
    [Test]
    public void CreateTm()
    {
        //Tm page object initilaztaion and definition
        Tm_page tmpageobj = new Tm_page();
        tmpageobj.MaterialDetails(driver);
    }
    [Test]
    public void EditTm()
    {
        //Edit Material data
        Tm_page tmpageobj = new Tm_page();
        tmpageobj.EditTm(driver);
    }
    [Test]
    public void DelTM()
    {

        // Delete Materail data
        Tm_page tmpageobj = new Tm_page();
        tmpageobj.DelTM(driver);
    }
    [TearDown]

    public void CloserTestRun()
    {
    }
}
       


