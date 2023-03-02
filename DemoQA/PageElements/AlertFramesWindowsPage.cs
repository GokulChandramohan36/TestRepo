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
    public class AlertFramesWindowsPage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement browserWindows()
        {
            IWebElement broserWindows = driver.FindElement(By.XPath("//*[text()='Browser Windows']"));
            return broserWindows;
        }
        public IWebElement alerts()
        {
            IWebElement alerts = driver.FindElement(By.XPath("//*[text()='Alerts']"));
            return alerts;
        }
        public IWebElement frames()
        {
            IWebElement frames = driver.FindElement(By.XPath("//*[text()='Frames']"));
            return frames;
        }

        public IWebElement nestedFrames() 
        {
            IWebElement nestedFrames = driver.FindElement(By.XPath("//*[text()='Nested Frames']"));
            return nestedFrames;

        }

        public IWebElement modals()
        {
            IWebElement modals = driver.FindElement(By.XPath("//*[text()='Modal Dialogs']"));
            return modals;
        }

        public void areAllElementsPresentInTheList()
        {
            Assert.True(browserWindows().Displayed);
            Assert.True(alerts().Displayed);
            Assert.True(frames().Displayed);
            Assert.True(nestedFrames().Displayed);
            Assert.True(modals().Displayed);    
        }

        public void clickBrowserWindows()
        {
            browserWindows().Click();
        }

        public void clickAlerts()
        {
            alerts().Click();
        }



    }
}
