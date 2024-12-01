using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class TMPage
    {
      public void CreateTimeRecord(IWebDriver driver)
        {
            try
            {
                //click on the create new button
                IWebElement createNewTimeButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createNewTimeButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("not able to locate the create new button");
            }
            Thread.Sleep(3000);
            //select the type code dropdown
            IWebElement typeCodedropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodedropDown.Click();

            Thread.Sleep(3000);
            //Select the Time from the dropdown
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            Thread.Sleep(3000);
            //pass value to the code textbox 
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("TA Programme");

            Thread.Sleep(3000);
            //pass value to the description textbox 
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("this time material");

            Thread.Sleep(5000);
            //pass value to the price per unit textbox 
            IWebElement priceTagOverLap = driver.FindElement
                (By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverLap.Click();


            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("$12");
            Wait.WaitToBeClickable(driver, "Id", "SaveButton",3);
            //click on the save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(3000);
            //click on the last record button
            IWebElement LastTimeRecord = driver.FindElement
                (By.XPath(" //*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastTimeRecord.Click();

            //check if the new time material record successfully created.Above is the steps for the test
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "TA Programme", "the time record was not created successfully");


            //if (newCode.Text == "TA Programme")
            //{
            //    Assert.Pass("the time record is created successfully");
            //}
            //else
            //{
            //    Assert.Fail("the time record was not created successfully");
            //}

        }

       public void EditTimeRecord(IWebDriver driver)
        {

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(3000);
           
            //click on the edit button
            IWebElement   editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
            editButton.Click();

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("code");
            Thread.Sleep(2000);

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("description");
            Thread.Sleep(2000);


            //Click save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1500);

            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();
            Thread.Sleep(1500);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editedCode.Text == "code")
            {
                Console.WriteLine("Record Edited successfully");
            }
            else
            {
                Console.WriteLine("Record has not been edited.");
            }




        }


        public void DeleteTimeRecord(IWebDriver driver)
 {
            //delete the record

            Thread.Sleep(4000); Thread.Sleep(2000);
            
            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            Thread.Sleep(1500);

            //Click OK to delete
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);

            driver.Navigate().Refresh();

            Thread.Sleep(4000);
            //Check if the record is deleted
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (deletedCode.Text != "Edit Code TA Programme")
            {
                Console.WriteLine("Record deleted successfully");
            }
            else
            {
                Console.WriteLine("Record has not been delete.");
            }

          


        }
    }
}
