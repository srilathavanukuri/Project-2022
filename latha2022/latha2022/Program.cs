// See https://aka.ms/new-console-template for more information

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");
// open chrome browser
IWebDriver driver = new ChromeDriver();
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
// Identify administration abd click
IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
Administration.Click();
// select time & materials from dropdown list
IWebElement tmOption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
tmOption.Click();
//click on create new button
driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
//select material from type code dropdown 
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();
IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
// Identify the code text box and input code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("latha2022");
//Identify descripton textbox and input description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("latha2022");
//Identify  input price box
IWebElement inputpriceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
inputpriceTextbox.SendKeys("15");
//click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);
//Identify if material record has been created successfully
IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
LastPage.Click();
IWebElement MaterialCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (MaterialCode.Text == "latha2022")
{
    Console.WriteLine("Material Record created sucecssfully. test pass");
}
    else
{    
        Console.WriteLine("Material record not created,test failed");
    }
Thread.Sleep(1500);
//Identify and Edit Button click
IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
EditButton.Click();
Thread.Sleep(1000);
//Identify and update Material record
// Identify Code text box and update update
IWebElement CodeBoxEdit = driver.FindElement(By.Id("Code"));
CodeBoxEdit.Clear();
CodeBoxEdit.SendKeys("2022latha");
//Identify Description Box and update 
IWebElement DescBoxEdit = driver.FindElement(By.Id("Description"));
DescBoxEdit.Clear();
DescBoxEdit.SendKeys("2022latha");
//Identify price unit  box and update
IWebElement PriceBoxInput = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
PriceBoxInput.Click();
IWebElement PriceEdit = driver.FindElement(By.Id("Price"));
PriceEdit.Clear();
PriceBoxInput.SendKeys("155");
//Identify Save button to update changes
IWebElement SaveAgain = driver.FindElement(By.Id("SaveButton"));
SaveAgain.Click();
Thread.Sleep(1000);
// Identify if changes updated successfully
IWebElement AgainLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
AgainLastPage.Click();
IWebElement UpdatedCodeBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
IWebElement UpdatedDescBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
if (UpdatedCodeBox.Text == "2022latha" && UpdatedDescBox.Text == "2022latha")
{
    Console.WriteLine("Updated successfully,test pass");
}
else
{
    Console.WriteLine("Update Failed,test failed");
}

//Identify delete button and click
IWebElement DelButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
DelButton.Click();
IAlert OKButton = driver.SwitchTo().Alert();
OKButton.Accept();
Thread.Sleep(500);
//Identify Refresh current page
IWebElement RefreshButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[5]/span"));
RefreshButton.Click();

//Identify if entries deleted successfully
IWebElement Deletion = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (Deletion.Text != "2022latha")
{
    Console.WriteLine("Succseefully Deleted.test pass");
}
else
{
    Console.WriteLine("Not Deleted,test failed");
}











