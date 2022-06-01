using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latha2022.pages
{
    public class Tm_page
    {
        private IWebDriver driver;

        public Tm_page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Tm_page()
        {
        }

        public void MaterialDetails(IWebDriver driver)
        {
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
            Thread.Sleep(1000);
         }

              public void EditTm(IWebDriver driver)
        {
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
        }
        public void DelTM(IWebDriver driver)
        {
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
        }
    }
}
