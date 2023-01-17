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
    public class termsPage
    {

        IWebDriver _driver;
        Terms terms;
        public termsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void isTermsLinkOpen()
        {

            terms = new Terms(_driver);
            Assert.That((_driver.Title), Is.EqualTo(terms.termsPageTitle));

        }
    }
}
