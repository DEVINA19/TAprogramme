using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TAProgramme.Pages
{
    public class LoginPage
    {
     //functions that allow users to login to TurnUP Portal
     public void LoginActions(IWebDriver driver)
        {
           
            //launch  turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            //identify username text box and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");


            //identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            //identify log in button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();


            //check if user has logged in successfully-test is the last one.Above is the steps for the test
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
          /*  if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user has logged in successfully");
            }
            else
            {
                Console.WriteLine("User has not logged in .Test  failed");
            }
            Thread.Sleep(3000);*/


        }


    }
}
