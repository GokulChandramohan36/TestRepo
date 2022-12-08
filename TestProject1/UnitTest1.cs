using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Initializing the driver
        IWebDriver driver;
        [TestInitialize]
       public void driverSetup()
        {
          Driver obj = new Driver();
          driver = obj.setDriver("https://www.google.co.in/");  
        }
        [TestMethod]
        public void TestMethod1()
        {
            pageClass pageObject = new pageClass(driver);
            pageObject.enterText("facebook");
            pageObject.pressEnter();

        }

    }
}
