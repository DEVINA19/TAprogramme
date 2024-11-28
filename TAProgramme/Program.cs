
using System.Data;
using System.Reflection.Metadata.Ecma335;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAProgramme.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open the chrome browser
        IWebDriver driver = new ChromeDriver();
        //login page object intilialization and definition
         LoginPage loginPageObj= new LoginPage();
        loginPageObj.LoginActions(driver);
        //Home page object intilialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);
        //TimeandMaterial  page object intilialization and definition
        TMPage tMPageObj = new TMPage();
        tMPageObj.CreateTimeRecord(driver);
        //edit the time record
        tMPageObj.EditTimeRecord(driver);
        //delete the record
        tMPageObj.DeleteTimeRecord(driver);


     }
}