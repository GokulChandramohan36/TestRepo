using DemoQA.DriverSetup;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace DemoQA.Hooks
{
    [Binding]
    public sealed class Hooks1 : driverSetup
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            String Url = "https://demoqa.com/";
            //driver = new EdgeDriver();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}