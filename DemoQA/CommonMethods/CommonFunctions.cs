using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.DriverSetup;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
     


namespace DemoQA.CommonMethods
{
    public class CommonFunctions : driverSetup
    {
        Actions act = new Actions(driver);
        public void setWait(String xpath)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(20);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);

            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            fluentWait.Until(x => x.FindElement(By.XPath(xpath)));
        }

        public void  scrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0,250)");
        }

        public void doubleClickOnElement(IWebElement ele)
        {
            act.DoubleClick(ele).Perform();
        }

        public void rightClickOnElement(IWebElement ele)
        {
            act.ContextClick(ele).Perform();    
        }

        public void dynamicClickOnElement(IWebElement ele)
        {
            act.Click(ele).Perform();   
        }

        

    }
}
