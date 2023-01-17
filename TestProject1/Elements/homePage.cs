using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Xpath
{

    
    public class homePage
    {
        IWebDriver _driver;
        public String facebookPageTitle = "Facebook – log in or sign up";
        public homePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement searchBar()
        {
            IWebElement searchBar = _driver.FindElement(By.XPath("//input[@title=\"Search\"]"));
            return searchBar ;
        }
        public IWebElement targetElement()
        {
            IWebElement targetElement = _driver.FindElement(By.XPath("//a[@href=\"https://www.facebook.com/\"]"));
            return targetElement;
        }
        public IWebElement createNewAccount()
        {
            IWebElement createNewAccount = _driver.FindElement(By.XPath("//a[contains(text(),\"Create New Account\")]"));
            return createNewAccount;
        }



        

    }
}
