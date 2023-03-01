using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.PageElements
{
    public class ElementsPage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        static ElementsPageConstants elements = new ElementsPageConstants();
        CommonFunctions common = new CommonFunctions();


        public IWebElement mainHeader()
        {
            IWebElement mainHeader = driver.FindElement(By.XPath("//" + locators.Div +"["+locators.text+"='"+elements.ElementsPageHeaderLabel+"']"));
            ///div[text()='Text Box']
            return mainHeader;
        }
        public IWebElement textBox() 
        {
            IWebElement textBox = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.textBox+"']"));
            //*[text()='Text Box']
            return textBox;
        }

        public IWebElement checkBox()
        {
            IWebElement checkBox = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.checkBox+"']"));
            return checkBox;
        }

        public void clickCheckBox()
        {
            checkBox().Click();
        }

        public IWebElement radioButton() 
        {
            IWebElement radioBtn = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.radioBtn+"']"));
            return radioBtn;
        }

        public IWebElement webTables()
        {
            IWebElement webTables = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.WebTables+"']"));
            return webTables;
        }

        public void clickWebTables()
        {
            webTables().Click();
            
        }
        public void clickButtonPage()
        {
            buttons().Click();
        }

        public void clickUploadDownloadPage()
        {
            Thread.Sleep(1000);
            common.scrollToBottom();
            UploadAndDownload().Click();
        }
        public IWebElement buttons()
        {
            IWebElement buttons = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.Buttons+"']"));
            return buttons;
        }

        public IWebElement links()
        {
            IWebElement links = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.Links+"']"));
            return links;
        }
        public IWebElement BrknLinksPages()
        {
            IWebElement brknLinkPages = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.BrokenLinksImgs+"']"));
            return brknLinkPages;
        }

        public IWebElement UploadAndDownload()
        {
            
            IWebElement uploadAndDownload = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.UploadAndDownload+"']"));
            return uploadAndDownload;
        }

        public IWebElement dynamicProperties()
        {
            IWebElement dynamicProperties = driver.FindElement(By.XPath("//*["+locators.text+"='"+elements.DynamicProperties+"']"));
            return dynamicProperties;
        }
        public void isElementsPageOpen()
        {
            common.setWait("//" + locators.Div + "[" + locators.text + "='" + elements.ElementsPageHeaderLabel + "']");
            Assert.True(mainHeader().Displayed);
            
        }

        public void areAllItemsDisplayedInTheMenu()
        {
            Assert.True(textBox().Displayed);
            Assert.True(checkBox().Displayed);
            Assert.True(radioButton().Displayed);
            Assert.True(webTables().Displayed);
            Assert.True(buttons().Displayed);
            Assert.True(links().Displayed); 
            Assert.True(BrknLinksPages().Displayed);
            Assert.True(UploadAndDownload().Displayed);
            Assert.True(dynamicProperties().Displayed);
        }

        public void clickTxtBox()
        {
            textBox().Click();
        }
        
        
    }
}
