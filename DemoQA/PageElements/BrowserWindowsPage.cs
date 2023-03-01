using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.PageElements
{
    public class BrowserWindowsPage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement newTabBtn()
        {
            IWebElement newTabBtn = driver.FindElement(By.XPath("//*[text()='New Tab']"));
            return newTabBtn;

        }

        public IWebElement newWindowBtn()
        {
            IWebElement newWindowBtn = driver.FindElement(By.XPath("//*[text()='New Window']"));
            return newWindowBtn;
        }

        public IWebElement newWindowMessage()
        {
            IWebElement newWindowMessage = driver.FindElement(By.XPath("//*[text()='New Window Message']"));
            return newWindowMessage;
        }

        public void checkAlltheButtons()
        {
            Assert.True(newTabBtn().Displayed);
            Assert.True(newWindowBtn().Displayed);
            Assert.True(newWindowMessage().Displayed);
        }

        public void clickNewTabBtn()
        {
            newTabBtn().Click();
        }

        public void clickNewWindowBtn() 
        {
            newWindowBtn().Click();
        }

        public void clickNewWindowMessage() 
        {
            newWindowMessage().Click();
        }

        public IWebElement newTabMessage()
        {


            IWebElement newTabMessage = driver.FindElement(By.XPath("//*[text()='This is a sample page']"));
            return newTabMessage;
        }


        public void verifyNewTab()
        {
            String parentWindow = driver.CurrentWindowHandle.ToString();
            String[] Windows = driver.WindowHandles.ToArray();
            
            foreach ( String w in Windows)
            {
                driver.SwitchTo().Window(w);

                try
                {
                    Assert.True(newTabMessage().Displayed);
                    Console.WriteLine("new window message is : " + newTabMessage().Text);
                }
                catch ( Exception NoSuchElementException ) 
                {
                    Console.WriteLine("No Element found");
                    
                }

                
                
            }
            driver.SwitchTo().Window(parentWindow);


        }
    }
}
