using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject1
{
    public class Driver
    {
    public IWebDriver setDriver(string url) 
         
        { 
            IWebDriver driver= new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
