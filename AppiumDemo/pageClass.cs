using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumTest
{
    public class pageClass
    {
        AppiumDriver driver;
        public pageClass(AppiumDriver driver)

        {
            this.driver = driver;

        }

        public void testAction()
        {
            AppiumElement a = driver.FindElement(ById.Id("com.ulsumobile.calculator:id/iv_8"));
            AppiumElement operation = driver.FindElement(ById.Id("com.ulsumobile.calculator:id/iv_cheng"));
            AppiumElement b = driver.FindElement(ById.Id("com.ulsumobile.calculator:id/iv_9"));
            AppiumElement res = driver.FindElement(ById.Id("com.ulsumobile.calculator:id/iv_deng"));
            a.Click();
            operation.Click();
            b.Click();
            res.Click();
        }

    }
}
