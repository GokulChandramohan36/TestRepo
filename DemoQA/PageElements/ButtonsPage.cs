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
    public class ButtonsPage : driverSetup
    {

        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement doubleClickBtn()
        {
            IWebElement doubleClickBtn = driver.FindElement(By.XPath("//*[@id='doubleClickBtn']"));
            return doubleClickBtn;
        }

        public IWebElement rightClickBtn()
        {
            IWebElement rightClickBtn = driver.FindElement(By.XPath("//*[@id='rightClickBtn']"));
            return rightClickBtn;
        }

        public IWebElement dynamicClickBtn()
        {
            IWebElement dynamicClickBtn = driver.FindElement(By.XPath("//*[text()='Click Me']"));
            return dynamicClickBtn;
        }

        public IWebElement doubleClickSuccessText()
        {
            common.setWait("//*[@id='doubleClickMessage']");
            IWebElement doubleClickSuccessText = driver.FindElement(By.XPath("//*[@id='doubleClickMessage']"));
            return doubleClickSuccessText;
        }
        public IWebElement rightClickSuccessText()
        {
            common.setWait("//*[@id='rightClickMessage']");
            IWebElement rightClickSuccessText = driver.FindElement(By.XPath("//*[@id='rightClickMessage']"));
            return rightClickSuccessText;
        }

        public IWebElement dynamicClickSuccessText()
        {
            common.setWait("//*[@id='dynamicClickMessage']");
            IWebElement dynamicClickSuccessText = driver.FindElement(By.XPath("//*[@id='dynamicClickMessage']"));
            return dynamicClickSuccessText;
        }
        public void verifyDoubleClick()
        {
            common.doubleClickOnElement(doubleClickBtn());
            Assert.True(doubleClickSuccessText().Displayed);

        }

        public void verifyRightClick()
        {
            common.rightClickOnElement(rightClickBtn());
            Assert.True(rightClickSuccessText().Displayed);
        }
        public void verifyDynamicClick()
        {
            common.dynamicClickOnElement(dynamicClickBtn());
            Assert.True(dynamicClickSuccessText().Displayed);
        }

        public void verifyIfAllBtnsArePresent()
        {
           Assert.True(doubleClickBtn().Displayed);
           Assert.True(rightClickBtn().Displayed);
           Assert.True(dynamicClickBtn().Displayed);
        }
    }
}
