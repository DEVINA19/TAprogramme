﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TAProgramme.Utilities
{
    public class Wait
    { 
        //generic function to wait for an element to be clickable
       
      public static void WaitToBeClickable(IWebDriver driver,string locatorType,string locatorValue,int seconds)
        {
           var  wait=new WebDriverWait(driver,new TimeSpan(0,0,seconds));
            if(locatorType =="XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

        }


    }
}