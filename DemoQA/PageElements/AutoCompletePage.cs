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
    public class AutoCompletePage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement multipleSearchBox()
        {
            IWebElement multipleSearchBox = driver.FindElement(By.XPath("//*[@id='autoCompleteMultipleInput']"));
            return multipleSearchBox;
        }

        public IWebElement singleSearchBox() 
        {
            IWebElement singleSearchBox = driver.FindElement(By.XPath("//*[@id='autoCompleteSingleInput']"));
            return singleSearchBox;
        }

        public void aretheSearchBoxesPresent()
        {
            common.setWait("//*[@id='autoCompleteMultipleContainer']");
            Assert.True(multipleSearchBox().Displayed);
            Assert.True(singleSearchBox().Displayed);   
        }

        public void enterMultipleColors(String value1,String value2)
        {
            //String[] key = value1.Split("");
            multipleSearchBox().SendKeys(value1);
           
      
           // driver.FindElement(By.XPath("//*[text()='White']")).Click();
            multipleSearchBox().SendKeys(Keys.Enter);
            multipleSearchBox().SendKeys(value2);
            multipleSearchBox().SendKeys(Keys.Enter);
            


        }

        public void enterSingleColor(string value1)
        {
            singleSearchBox().SendKeys(value1);
            singleSearchBox().SendKeys(Keys.Enter);
        }
    }
}
