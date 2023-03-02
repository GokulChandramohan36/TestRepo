using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoQA.StepDefinition
{
    [Binding]
    public class DatePicker: driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();
        [Then(@"I set the date in the datepicker using ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void ThenISetTheDateInTheDatepickerUsing(string month, string yr, string day)
        {
            setTimeDate(month,yr,day);
        }

        public IWebElement datepicker()
        {
            IWebElement datepicker = driver.FindElement(By.XPath("//*[@id='datePickerMonthYearInput']"));
            return datepicker;
        }

        public IWebElement timeDatePicker()
        {
            IWebElement timeDatePicker = driver.FindElement(By.XPath("//*[@id='dateAndTimePickerInput']"));
            return timeDatePicker;
        }

        public void clickTimeDatePicker()
        {
            timeDatePicker().Click();
        }

        public IWebElement nextMnth()
        {
            IWebElement nextMnth = driver.FindElement(By.XPath("//*[text()='Next Month']"));
            return nextMnth;
        }

        public IWebElement prvsMnth()
        {
            IWebElement prvsMnth = driver.FindElement(By.XPath("//*[text()='Previous Month']"));
            return prvsMnth;
        }

        public IWebElement selectMnth()
        {
            IWebElement selectMnth = driver.FindElement(By.XPath("//*[@class='react-datepicker__month-read-view']"));
            return selectMnth;
        }

        public IWebElement selectYear()
        {
            IWebElement selectYear = driver.FindElement(By.XPath("//*[@class='react-datepicker__year-read-view']"));
            return selectYear;
        }

        public void setTimeDate(String Month,String Year,String Day)
        {
            timeDatePicker().Click();
            selectMnth().Click();
            driver.FindElement(By.XPath("//*[text()='"+Month+"']")).Click();
            
            selectYear().Click();
            int Count = 2;
            DateTime now = DateTime.Now;
            int currentYr = now.Year;
            int userYr = Int32.Parse(Year);

            for (int i = 1; i < Count; i ++)
            {
                try
                {
                    common.scrollToBottom();
                    driver.FindElement(By.XPath("//*[text()='"+Year+"']")).Click();
                }
                catch(Exception e) 
                {
                    if(currentYr>userYr)
                    {
                        driver.FindElement(By.XPath("//*[@class='react-datepicker__navigation react-datepicker__navigation--years react-datepicker__navigation--years-previous']")).Click();

                    }
                    else
                    {
                        driver.FindElement(By.XPath("//*[@class='react-datepicker__navigation react-datepicker__navigation--years react-datepicker__navigation--years-upcoming']")).Click();
                    }
                    
                    Count++;
                }
                

            }
            common.setWait("//*[text()='" + Day + "']");
            driver.FindElement(By.XPath("//*[text()='" + Day + "']")).Click();










        }
        public void SelectTime(String Time)
        {
            IList<IWebElement> allProduct = driver.FindElements(By.XPath("//*[@class='react-datepicker__time-list']"));

            foreach (IWebElement product in allProduct) 
            {
                try
                {
                    driver.FindElement(By.XPath("//*[text()='" + Time + "']")).Click();

                }
                catch (Exception e)
                { 
                    Console.WriteLine(e);
                }
                
            }
        }

        [Then(@"I set Time as ""([^""]*)""")]
        public void ThenISetTimeAs(string Time)
        {
            SelectTime(Time);
        }


        [Then(@"I validate the set Month as ""([^""]*)"" Year as ""([^""]*)"" Date as ""([^""]*)"" Time as ""([^""]*)""")]
        public void ThenIValidateTheSetMonthAsYearAsDateAsTimeAs(string month, string year, string date, string Time)
        {
            string time = Time.Substring(1, Time.Length - 1);
            String expectedResult = month + " " + date+", "+year+ " " + time;
            String actualResult = timeDatePicker().GetAttribute("value");
            Console.WriteLine("expected " + expectedResult);
            Console.WriteLine("actual " + actualResult);
            Assert.True(actualResult.Contains(expectedResult));
        }



    }
}
