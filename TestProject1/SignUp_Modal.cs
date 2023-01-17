using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProject1.Elements;
using TestProject1.Xpath;

namespace TestProject1
{
    public class SignUp_Modal
    {
        IWebDriver _driver;
        SignUp obj;
        
        public SignUp_Modal(IWebDriver driver)
        {
            _driver = driver;
        }


        //To validate that the pop up modal is open 
        public void isModalOpen()
        {
            obj = new SignUp(_driver);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'Sign Up')]")));
            String actual = _driver.FindElement(By.XPath("//div[contains(text(),'Sign Up')]")).Text;
            Assert.That(actual, Is.EqualTo(obj.modalHeader));
            

        }

        //To enter all the details
        public void enterDetails(String fname, String lname, String Mobile, String Password, String date, String month, String year, String gender)

        {
            obj = new SignUp(_driver);
            obj.firstName().SendKeys(fname);
            obj.lastName().SendKeys(lname);
            obj.mobileNumber().SendKeys(Mobile);
            obj.newPassword().SendKeys(Password);
            obj.dateDropDown().SelectByText(date);
            obj.monthDropDown().SelectByText(month);
            obj.yearDropDown().SelectByText(year);
           
            if (gender.Equals("Female"))
            {
                
                obj.femaleGenderRadioBtn().Click(); 
            }
            else if (gender.Equals("Male"))
            {
                obj.maleGenderRadioBtn().Click();
            }
            else
            {
                obj.otherGenderRadioBtn().Click(); 
            }
        }

        //To click on submit and wait till the error dialog box
        public void clickSubmit()
        {
            obj = new SignUp(_driver);
            Boolean actual = obj.signupBtn().Displayed;
            Console.WriteLine(actual);
            Assert.That(actual,Is.EqualTo(true));
            obj.signupBtn().Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"reg_error_inner\"]")));
        }

        //To open All links and validate them
        public void openAllLinks()
        {
            obj = new SignUp(_driver);
            obj.learnMoreLink().Click();
            obj.termsLink().Click();
            obj.policyLink().Click();   
            obj.cookiesLink().Click();
            learnMorePage(_driver);
            termsPage(_driver);
            privacyPolicyPage(_driver); 

        }

        //To validate learn More Page

        public void learnMorePage(IWebDriver driver)
        {
            List<string> lstWindow = driver.WindowHandles.ToList();
            String currentWindow = driver.CurrentWindowHandle;
            LearnMore obj = new LearnMore(driver);
            learnMorePage learnMoreObject = new learnMorePage(driver);
            foreach (string window in lstWindow)
            {
               

                    
                if (driver.SwitchTo().Window(window).Title.Equals(obj.learnMorePageTitle))
                {
                    Console.WriteLine(_driver.Title);
                    break;
                }
                else
                {
                    
                    driver.SwitchTo().Window(currentWindow);
                }

            }
            learnMoreObject.isLearnMoreLinkOpen();


        }

        //To validate Terms Page
        public void termsPage(IWebDriver driver)
        {
            List<string> lstWindow = driver.WindowHandles.ToList();
            String currentWindow = driver.CurrentWindowHandle;
            Terms obj = new Terms(driver);
            termsPage termsObject = new termsPage(driver);
            foreach (string window in lstWindow)
            {



                if (driver.SwitchTo().Window(window).Title.Equals(obj.termsPageTitle))
                {

                    Console.WriteLine(_driver.Title);
                    break;
                }
                else
                {
                    
                    driver.SwitchTo().Window(currentWindow);
                }

            }
            termsObject.isTermsLinkOpen();


        }

        //To validate Privacy Policy Page
        public void privacyPolicyPage(IWebDriver driver)
        {
            List<string> lstWindow = driver.WindowHandles.ToList();
            String currentWindow = driver.CurrentWindowHandle;
            privacyPolicy obj = new privacyPolicy(driver);
            privacyPage privacyObject = new privacyPage(driver);
            foreach (string window in lstWindow)
            {



                if (driver.SwitchTo().Window(window).Title.Equals(obj.privacyPolicyTitle))
                {
                    Console.WriteLine(_driver.Title);
                    break;
                }
                else
                {

                    driver.SwitchTo().Window(currentWindow);
                }

            }
            privacyObject.isPrivacyLinkOpen();


        }

    }
}

