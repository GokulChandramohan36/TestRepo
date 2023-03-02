using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
                            


namespace DemoQA.DriverSetup
{
   
    public class driverSetup
    {
        public static IWebDriver driver;
        

         

        public IWebDriver setDriver(String browserName,String Url)
        {
            switch (browserName)

            {
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(Url);
                    break;
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    driver.Navigate().GoToUrl(Url);
                    break;

                default:
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(Url);
                    break;
            }
            return driver; 
        }

    }
}
