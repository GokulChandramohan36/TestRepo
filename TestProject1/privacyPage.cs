using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject1.Elements;
using TestProject1.Xpath;

namespace TestProject1
{
    public class privacyPage
    {

        IWebDriver _driver;
        privacyPolicy privacy;
        public privacyPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void isPrivacyLinkOpen()
        {

            privacy = new privacyPolicy(_driver);
            Assert.That((_driver.Title),Is.EqualTo(privacy.privacyPolicyTitle));
            //Assert.That((_driver.Title), Is.SubsetOf(privacy.privacyPolicyTitle));

        }
    }
}
