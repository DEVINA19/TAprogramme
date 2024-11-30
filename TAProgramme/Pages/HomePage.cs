using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class HomePage
    {

    public void NavigateToTMPage(IWebDriver driver)
        {
            //Navigate to the time and material
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();
            Wait.WaitToBeClickable(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",10);

            //click on the time and material link
            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
            Thread.Sleep(3000);

        }


    }
}
