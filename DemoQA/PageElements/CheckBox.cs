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
    public class CheckBox : driverSetup

    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();


        public IWebElement expandAll()
        {
            IWebElement expandAll = driver.FindElement(By.XPath("//button[@title='Expand all']"));
            return expandAll;
        }
        public IWebElement resultElement()
        {
            IWebElement resultElement = driver.FindElement(By.XPath("//*[@class='text-success']"));
            return resultElement;
        }

        public IWebElement checkBoxElement(String Value)
        {
            
                expandAll().Click();
                common.setWait("//*[" + locators.text + "='" + Value + "']");
                IWebElement checkBoxElement = driver.FindElement(By.XPath("//*[" + locators.text + "='" + Value + "']"));
                //*[text()='Home']
                return checkBoxElement;
        }
        public void clickdesiredCheckbox(String Value)
        {
            common.scrollToBottom();
            checkBoxElement(Value).Click();
            
            
        }

        public void checkTheResult(String Value)
        {
            common.scrollToBottom();
            String res = resultElement().Text.Substring(resultElement().Text.LastIndexOf(":") + 1).ToLower();
            Assert.True(res.Contains(Value.ToLower()));


        }
    }
}
