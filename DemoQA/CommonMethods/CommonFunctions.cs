using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public void hover(IWebElement ele)
        {
            act.MoveToElement(ele).Perform();
        }

        public void dragAndDropEle(IWebElement src,IWebElement des)
        {
            act.MoveToElement(src).Perform();
            act.DragAndDrop(src, des).Release().Perform();
        }

        public void dragAndDrop(IWebElement src,IWebElement des)
        {
            //act.DragAndDrop(src, des).Perform();
            act.ClickAndHold(src).MoveToElement(des).Release().Perform();
        }
        public void dragAndDrop2(IWebElement src, IWebElement des)
        {


            Point p = des.Location;
            int x = p.X;
            int y = p.Y;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('style','visibility:visible;');", des);
            
            act.Reset();
            act.ClickAndHold(src).MoveToElement(des).Release().Perform();


        }



        public void  scrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0,250)");
        }

        public void scrollDownABit()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0,450)");
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
