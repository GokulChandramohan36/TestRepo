using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Xpath
{


    public class LearnMore
    {
        IWebDriver _driver;
        public String learnMorePageTitle = "Information for people who don't use Meta Products | Facebook Help Centre";
        public LearnMore(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
