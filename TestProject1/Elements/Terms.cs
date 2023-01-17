using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Elements
{
    public class Terms
    {
        IWebDriver _driver;
        public String termsPageTitle = "Facebook";
        public Terms(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
