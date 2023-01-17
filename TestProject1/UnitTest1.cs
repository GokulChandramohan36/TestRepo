using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
namespace TestProject1
{
    public class UnitTest1
    {
        //Initializing the driver
        IWebDriver driver;
        [SetUp]
       public void driverSetup()
        {
          Driver obj = new Driver();
          driver = obj.setDriver("https://www.google.co.in/");  
        }


        //Test Method
        [Test]
        public void TestMethod1()
        {
            pageClass pageObject = new pageClass(driver);
            SignUp_Modal pageObject_2 = new SignUp_Modal(driver);
            
            driver.Navigate().Refresh();
            pageObject.enterText("facebook");
            //pageObject.submit();
            pageObject.clickFaceBookLink();
            pageObject.clickCreateNewAccount();
            pageObject_2.isModalOpen();
            pageObject_2.enterDetails("Gokul","Chandramohan","1234567890","Gokul@demo123","3","Jan","1998","Male");
            pageObject_2.clickSubmit();
            pageObject_2.openAllLinks();
            


        }

        



        //Close the driver
        [TearDown]

        public void tearDown()
        {
            driver.Quit();
        }

    }
}
