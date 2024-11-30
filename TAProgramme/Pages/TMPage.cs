using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class TMPage
    {
      public void CreateTimeRecord(IWebDriver driver)
        {

            //click on the create new button
            IWebElement createNewTimeButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewTimeButton.Click();

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
            if (newCode.Text == "TA Programme")
            {
                Console.WriteLine("the time record is created successfully");
            }
            else
            {
                Console.WriteLine("the time record was not created successfully");
            }

        }

       public void EditTimeRecord(IWebDriver driver)
        {
            //fhjkhghjklfghjk,l
        }
        public void DeleteTimeRecord(IWebDriver driver)
        {
            //delete the record

            IWebElement deleteRecordButton = driver.FindElement(By.XPath
               ("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[last()]/a[2]"));
            deleteRecordButton.Click();
            // Switch to the confirmation window
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();


        }
    }
}
