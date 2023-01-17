using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Elements
{
    public class cookiePolicy
    {
        IWebDriver _driver;
        public String cookiePolicyTitle = "Meta Cookies Policy | Privacy Centre | Manage your privacy on Facebook, Instagram and Messenger | Facebook Privacy";
        public cookiePolicy(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
