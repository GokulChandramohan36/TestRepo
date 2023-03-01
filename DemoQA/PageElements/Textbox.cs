using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.PageElements
{
    public class Textbox : driverSetup
    {
        textBoxConstants _textBox = new textBoxConstants();
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();
        public IWebElement userName()
        {
            IWebElement userName = driver.FindElement(By.XPath("//*[@"+locators.Id+"='"+_textBox.username+"']"));
            //*[@id='userName']
            return userName;
        }
        public IWebElement email() 
        {
            IWebElement email = driver.FindElement(By.XPath("//*[@"+locators.Id+"='"+_textBox.email+"']"));
            return email;
        }

        public IWebElement currentAddress() 
        {
            IWebElement currentAddress = driver.FindElement(By.XPath("//*[@"+locators.Id+"='"+_textBox.currentAddress+"']"));
            return currentAddress;
        }

        public IWebElement permanentAddress() 
        {
            IWebElement permanentAddress = driver.FindElement(By.XPath("//*[@"+locators.Id+"='"+_textBox.permAddress+"']"));
            return permanentAddress;
        }

        public IWebElement submitBtn()
        {
            IWebElement submitBtn = driver.FindElement(By.XPath("//*[@"+locators.Id+"='"+_textBox.submit+"']"));
            return submitBtn;
        }

        public void enterDetails(String name,String Email,String Address,String permAddress)
        {
            userName().SendKeys(name);
            email().SendKeys(Email);
            currentAddress().SendKeys(Address);
            permanentAddress().SendKeys(permAddress);
        }

        public IWebElement resName()
        {
            IWebElement resName = driver.FindElement(By.XPath("//*[@id='name']"));
            return resName;
        }

        public IWebElement resEmail()
        {
            IWebElement resEmail = driver.FindElement(By.XPath("//*[@id='email']"));
            return resEmail;
        }

        public IWebElement resAddress() 
        {
            IWebElement resAddress = driver.FindElement(By.XPath("(//*[@id='currentAddress'])[2]"));
            return resAddress;
        }

       

        public IWebElement resPermanentAddress() 
        {
            IWebElement resPermanentAddress = driver.FindElement(By.XPath("(//*[@id='permanentAddress'])[2]"));
            return resPermanentAddress;
        }

        public void validateName(String name)
        {
            String resultName = (resName().Text.Substring(resName().Text.LastIndexOf(":") + 1));
            Assert.True(resultName.Equals(name));


        }
        public void validateEmail(String email) 
        {
            String resultEmail = (resEmail().Text.Substring(resEmail().Text.LastIndexOf(":") + 1));
            Assert.True(resultEmail.Equals(email));
        }

        public void validateAddress(String Address) 
        {
           
            String resultAddress = (resAddress().Text.Substring(resAddress().Text.LastIndexOf(":") + 1));

            
            Assert.True(resultAddress.Equals(Address));
        }

        public void validatePermAddress(String PermAddress) 
        {
            String resultPermAddress = (resPermanentAddress().Text.Substring(resPermanentAddress().Text.LastIndexOf(":") + 1));
            Console.WriteLine(resultPermAddress);
            Assert.True(resultPermAddress.Equals(PermAddress));
        }

        public void validateAllDetails(String name, String Email, String Address, String permAddress)
        {
            validateName(name);
            validateEmail(Email);
            validateAddress(Address);
            validatePermAddress(permAddress);
           

        }

        public void clickSubmit()
        {
            common.scrollToBottom();
            submitBtn().Click();
            IWebElement resName = driver.FindElement(By.XPath("//*[@id='name']"));
            String res = resName.Text;
            Console.Write(res.Substring(res.LastIndexOf(":")+1));

        }
    }
}
