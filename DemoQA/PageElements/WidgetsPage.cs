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
    public class WidgetsPage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement autoComplete()
        {
            
            IWebElement automComplete = driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
            return automComplete;
        }

        public IWebElement datePicker()
        {
            IWebElement datePicker = driver.FindElement(By.XPath("//*[text()='Date Picker']"));
            return datePicker;
        }

        public IWebElement toolTip()
        {
            IWebElement toolTip = driver.FindElement(By.XPath("//*[text()='Tool Tips']"));
            return toolTip;
        }

        public void clickToolTip()
        {
            toolTip().Click();
        }
        public void clickAutoComplete()
        {
            autoComplete().Click(); 

        }

        public void clickDatePicker()
        {
            datePicker().Click();
        }

        public void areAllElementsPresent()
        {
            common.scrollToBottom();
            common.setWait("//*[text()='Auto Complete']");
            Assert.True(autoComplete().Displayed);
            Assert.True(datePicker().Displayed);
            Assert.True(toolTip().Displayed);
        }

        


    }
}
