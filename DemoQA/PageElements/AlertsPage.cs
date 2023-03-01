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
    public class AlertsPage :driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement alertBoxWithActionsBtn()
        {
            IWebElement alertBoxWithActionsBtn = driver.FindElement(By.XPath("//*[@id='confirmButton']"));
            return alertBoxWithActionsBtn;
        }

        public IWebElement alertWithPrompt()
        {
            IWebElement alertWithPrompt = driver.FindElement(By.XPath("//*[@id='promtButton']"));
            return alertWithPrompt;
        }

        public void clickAlertWithConfirmation()
        {
            alertBoxWithActionsBtn().Click();
        }

        public void clickAlertWithPrompt() 
        {
            alertWithPrompt().Click();
        }

        public void verifyAcceptAlertWithConfirmation()
        {
            driver.SwitchTo().Alert().Accept();


        }
        public void verifyDismissAlertWithConfirmation()
        {
            driver.SwitchTo().Alert().Dismiss();

        }

        public void verifyAlertsWithConfirmation()
        {
            clickAlertWithConfirmation();
            verifyAcceptAlertWithConfirmation();
            clickAlertWithConfirmation();
            verifyDismissAlertWithConfirmation();
        }

        public void verifyPromptAlert()
        {
            clickAlertWithPrompt();
            driver.SwitchTo().Alert().SendKeys("Helloooo");
            driver.SwitchTo().Alert().Accept();
            

        }

    }
}
