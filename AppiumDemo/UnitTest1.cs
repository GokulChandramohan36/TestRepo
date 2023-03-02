using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;

namespace AppiumTest
{
    [TestClass]

    public class UnitTest1
    {
        AppiumOptions cap;
        AppiumDriver driver;


        //Driver setup and capabilities setup
        [TestInitialize]

        public void setCapabilities()
        {

            DriverSetup obj1 = new DriverSetup(driver);
            obj1.setCap(cap);
            driver = obj1.setDriver();
        }

        //Test case -1 
        [TestMethod]
        public void TestMethod1()
        {
            pageClass obj = new pageClass(driver);
            obj.testAction();

        }


        //Tear Down 
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}

