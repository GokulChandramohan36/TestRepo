using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.PageElements
{
    public class ToolTipPage :driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement buttonToolTip()
        {
            common.setWait("//*[@id='toolTipButton']");
            IWebElement buttonToolTip = driver.FindElement(By.XPath("//*[@id='toolTipButton']"));
            return buttonToolTip;
        }

        public IWebElement textToolTip()
        {
            IWebElement textToolTip = driver.FindElement(By.XPath("//*[@id='toolTipTextField']"));
            return textToolTip;
        }

        public IWebElement buttonToolTipInfo()
        {
            
            IWebElement buttonToolTipInfo = driver.FindElement(By.XPath("//*[text()='You hovered over the Button']"));
            return buttonToolTipInfo;
        }

        public IWebElement textToolTipInfo() 
        {
            IWebElement textToolTipInfo = driver.FindElement(By.XPath("//*[text()='You hovered over the text field']"));
            return textToolTipInfo;
        }

        public void getToolTipInfo()
        {
            Thread.Sleep(2000);
            common.hover(buttonToolTip());
           
            String info = buttonToolTipInfo().Text;
            Console.WriteLine("The button Tool Tip Info is : "+info);
            


        }

        public void getTextToolTipInfo()
        {
            Thread.Sleep(2000);
            common.hover(textToolTip());
            String textInfo = textToolTipInfo().Text;
            Console.WriteLine("The text Tool Tip Info is : "+textInfo);
        }

        
    }
}
