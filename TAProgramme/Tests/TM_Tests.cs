using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TAProgramme.Pages;
using TAProgramme.Utilities;

namespace TAProgramme.Tests
{
    [TestFixture]
    public class TM_Tests: CommonDriver
    {
        //setup, createtimesteps,closetestrun
        //new browser,setup,edit time steps,closetestrun
        //new browser,setup,delete time steps,closetestrun

        [SetUp]
        public void SetUpSteps()
        {
            //open chrome  Browser
            driver = new ChromeDriver();
            //login page object intilialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
            //Home page object intilialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);

        }
        [Test]
        public void CreateTime_Steps()
        {
            //TimeandMaterial  page object intilialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);


        }
        [Test]
        public void EditTime_Steps()
        {
            //edit the time record
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Steps()
        {
            //delete the record
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
        driver.Quit();
        
        }

    }
}
