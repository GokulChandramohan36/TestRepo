using DemoQA.DriverSetup;
using OpenQA.Selenium.DevTools.V108.WebAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using DemoQA.Constants;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V108.DOM;
using DemoQA.CommonMethods;
using OpenQA.Selenium.Interactions;

namespace DemoQA.PageElements


{
    public class HomePage : driverSetup
    {


        static XpathLocators locators = new XpathLocators();
        static HomePageConstants home = new HomePageConstants();
        CommonFunctions common = new CommonFunctions();

        public IWebElement homePageBottomLabel()
        {
            IWebElement homePageBottomLabel = driver.FindElement(By.XPath("//*[contains(" + locators.text + "," + home.homePageBottomLabel + ")]"));
            return homePageBottomLabel;
        }

        public IWebElement ElementLink()
        {
            
            //IWebElement ElementLink = driver.FindElement(By.XPath("//*[" +locators.text+"='" + home.ElementsLabel + "']//preceding::div[1]"));
            IWebElement ElementLink = driver.FindElement(By.XPath("(//*[@stroke='currentColor'])[1]"));
            return ElementLink;
        }

        public IWebElement alertsLink()
        {
            IWebElement alertsLink = driver.FindElement(By.XPath("(//*[@stroke='currentColor'])[3]"));
            return alertsLink;

        }

        public IWebElement widgets()
        {
            IWebElement widgets = driver.FindElement(By.XPath("(//*[@stroke='currentColor'])[4]"));
            return widgets;
        }

        public IWebElement interactions()
        {
            IWebElement interactions = driver.FindElement(By.XPath("(//*[@stroke='currentColor'])[5]"));
            return interactions;
        }

        public void isHomePageOpen()
        {
            Assert.True(homePageBottomLabel().Displayed);
        }

        public void ClickElements()
        {
            common.setWait("//*[" + locators.text + "='" + home.ElementsLabel + "']//preceding::div[1]");
            common.scrollToBottom();
            Assert.True(ElementLink().Displayed);
            ElementLink().Click();
           
            
        }

        public void clickAlertLink()
        {
            common.setWait("(//*[@stroke='currentColor'])[3]");
            common.scrollToBottom();
            Assert.True(alertsLink().Displayed); 
            alertsLink().Click();
        }

        public void clickWidgetsLink()
        {
            common.setWait("(//*[@stroke='currentColor'])[4]");
            common.scrollToBottom();
            Assert.True(widgets().Displayed);
            widgets().Click();
        }

        public void clickInteractionsLink()
        {
            common.setWait("(//*[@stroke='currentColor'])[5]");
            common.scrollToBottom();
            Assert.True(interactions().Displayed);
            interactions().Click();

            
        }

    }
}

