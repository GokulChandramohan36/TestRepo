using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppiumTest
{
    public class DriverSetup
    {
        AppiumDriver driver;
        AppiumOptions cap;
        Uri url;

        public DriverSetup(AppiumDriver driver)
        {
            this.driver = driver;
        }

        public void setCap(AppiumOptions capabilities)
        {
            cap = capabilities;
            cap = new AppiumOptions();
            cap.PlatformName = "Android";
            cap.DeviceName = "emulator-5554";
            cap.PlatformName = "9";
            cap.App = "C:\\Users\\Gokul.Chandramohan\\Downloads\\calculator.apk";
            url = new Uri("http://127.0.0.1:4723/wd/hub");
        }

        public AppiumDriver setDriver()
        {
            driver = new AndroidDriver(url, cap);
            Thread.Sleep(4000);
            return driver;
        }

    }
}

