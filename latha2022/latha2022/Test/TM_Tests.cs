// See https://aka.ms/new-console-template for more information

using latha2022.pages;
using latha2022.Test;
using latha2022.utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace latha2022.Test;

[TestFixture]
[Parallelizable]
public class TM_Tests : commonDriver
 {
        //Page Object initialization
 Tm_page tmPageObj = new Tm_page();
Home_page homepageobj = new Home_page();

[SetUp]
public void LoginActions()
{
    //Open Chrome Browser
    driver = new ChromeDriver();

    //login page object initialisation and definition
    login_page loginPageObj = new login_page();
    loginPageObj.Loginsteps(driver);

    //home page object initialisation and definition
    Home_page homepageObj = new Home_page();
    homepageObj.GoToTMHomePage(driver);
}
[Test, Order(1), Description("Create Time and Material record with valid data")]
public void MaterialDetails()
{

    //Home Page Object initialization and definition
    Tm_page tmPageObj = new Tm_page();
    tmPageObj.MaterialDetails(driver);
        homepageobj.GoToTMHomePage(driver);

        //Tm page object initilaztaion and definition
        tmPageObj.MaterialDetails(driver);
}
    [Test, Order(2), Description("Edit Time and Material record  created in test1")]
    public void EditTm()
    {
        //home page object initialisation and definition
        homepageobj.GoToTMHomePage(driver);
        //Edit record
        tmPageObj.EditTm(driver);
    }
    [Test, Order(3), Description("Delete Time and Material record  updated in test2")]
    public void DelTM()
    {
        //home page object initialisation and definition
        homepageobj.GoToTMHomePage(driver);

        //Delete record
        tmPageObj.DelTM(driver);
    }

}

