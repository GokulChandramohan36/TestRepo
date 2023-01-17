using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject1.Xpath;

namespace TestProject1
{
    public class learnMorePage
    {

        IWebDriver _driver;
        LearnMore learnMoreObject;
        public learnMorePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void isLearnMoreLinkOpen()
        {

            learnMoreObject = new LearnMore(_driver);
            Assert.That((_driver.Title), Is.EqualTo(learnMoreObject.learnMorePageTitle));

        }
    }
}
