using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Elements
{
    public  class privacyPolicy
    {
        IWebDriver _driver;
        public String privacyPolicyTitle = "Meta Privacy Policy – How Meta collects and uses user data | Privacy Centre | Manage your privacy on Facebook, Instagram and Messenger | Facebook Privacy";
        public privacyPolicy(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
