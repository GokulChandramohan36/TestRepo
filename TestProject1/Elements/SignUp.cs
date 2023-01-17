using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Xpath
{
    public class SignUp
    {
        IWebDriver _driver;
        public String modalHeader = "Sign Up";

        public SignUp(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement firstName()
        {
            IWebElement firstName = _driver.FindElement(By.XPath("//input[@name=\"firstname\"]"));
            return firstName;
        }
        public IWebElement lastName()
        {
            IWebElement lastName = _driver.FindElement(By.XPath("//input[@name=\"lastname\"]"));
            return lastName;
        }
        public IWebElement mobileNumber()
        {
            IWebElement mobileNumber = _driver.FindElement(By.XPath("//input[@name=\"reg_email__\"]"));
            return mobileNumber;
        }
        public IWebElement newPassword()
        {
            IWebElement newPassword = _driver.FindElement(By.XPath("//input[@name=\"reg_passwd__\"]"));
            return newPassword;
        }
        public SelectElement dateDropDown()
        {
            SelectElement dateDropDown = new SelectElement(_driver.FindElement(By.XPath("//select[@title=\"Day\"]")));
            return dateDropDown;
        }
        public SelectElement monthDropDown()
        {
            SelectElement monthDropDown = new SelectElement(_driver.FindElement(By.XPath("//select[@title=\"Month\"]")));
            return monthDropDown;
        }
        public SelectElement yearDropDown()
        {
            SelectElement yearDropDown = new SelectElement(_driver.FindElement(By.XPath("//select[@title=\"Year\"]")));
            return yearDropDown;
        }
        public IWebElement femaleGenderRadioBtn()
        {
            IWebElement femaleGenderRadioBtn = _driver.FindElement(By.XPath("//input[@value=\"1\"]"));
            return femaleGenderRadioBtn;
        }
        public IWebElement maleGenderRadioBtn()
        {
            IWebElement maleGenderRadioBtn = _driver.FindElement(By.XPath("//input[@value=\"2\"]"));
            return maleGenderRadioBtn;
        }
        public IWebElement otherGenderRadioBtn()
        {
            IWebElement otherGenderRadioBtn = _driver.FindElement(By.XPath("//input[@value=\"3\"]"));
            return otherGenderRadioBtn;
        }
        public IWebElement signupBtn()
        {
            IWebElement signupBtn = _driver.FindElement(By.XPath("//button[contains(text(),'Sign Up')]"));
            return signupBtn;
        }
        public IWebElement learnMoreLink()
        {
            IWebElement learnMoreLink = _driver.FindElement(By.XPath("//a[contains(text(),\"Learn more\")]"));
            return learnMoreLink;   
        }

        public IWebElement errorLabel()
        {
            IWebElement errorLabel = _driver.FindElement(By.XPath("//*[@id=\"reg_error_inner\"]"));
            return errorLabel;
        }

        public IWebElement termsLink() 
        {
            IWebElement termsLink = _driver.FindElement(By.XPath("//a[@id=\"terms-link\"]"));
            return termsLink;
        }
        public IWebElement policyLink() 
        {
            IWebElement policyLink = _driver.FindElement(By.XPath("//a[@id=\"privacy-link\"]"));
            return policyLink;
        }

        public IWebElement cookiesLink()
        {
            IWebElement cookiesLink = _driver.FindElement(By.XPath("//a[@id=\"cookie-use-link\"]"));
            return cookiesLink;
        }
    }
}
