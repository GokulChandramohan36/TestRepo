using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoQA.PageElements
{
    public class WebTable : driverSetup
    {
        
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();
        WebTableConstants webtableConst = new WebTableConstants();

        public void isWebTablePageOpen()
        {

            Assert.True(webTableHeader().Displayed);
        }
        public IWebElement webTableHeader()
        {
            common.setWait("//"+locators.Div+"["+locators.text+"='"+webtableConst.webTablesHeader+"']");
            IWebElement webTableHeader = driver.FindElement(By.XPath("//"+locators.Div+"["+locators.text+"='"+webtableConst.webTablesHeader+"']"));
            //div[text()='Web Tables']
            return webTableHeader;
        }

        public IWebElement addNewRecordButton()
        {
            IWebElement addNewRecordButton = driver.FindElement(By.XPath("//*[@id='addNewRecordButton']"));
            return addNewRecordButton;
        }


        public void clickAddNewRecords()
        {
            addNewRecordButton().Click();

        }
        public IWebElement firstNameTxtBox()
        {
            common.setWait("//*[@id='firstName']");
            IWebElement firstNameTxtBox = driver.FindElement(By.XPath("//*[@id='firstName']"));
            return firstNameTxtBox;
        }

        public IWebElement lastNameTxtBox()
        {
            IWebElement lastNameTxtBox = driver.FindElement(By.XPath("//*[@id='lastName']"));
            return lastNameTxtBox;
        }
        public IWebElement ageTxtBox()
        {
            IWebElement ageTxtBox = driver.FindElement(By.XPath("//*[@id='age']"));
            return ageTxtBox;
        }

       public IWebElement emailTxtBox()
        {
            IWebElement emailTxtBox = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            return emailTxtBox;
        }

        public IWebElement salaryTxtBox()
        {
            IWebElement salaryTxtBox = driver.FindElement(By.XPath("//*[@id='salary']"));
            return salaryTxtBox;

        }

        public IWebElement deptTxtBox()
        {
            IWebElement deptTxtBox = driver.FindElement(By.XPath("//*[@id='department']"));
            return deptTxtBox;

        }
        public IWebElement submit()
        {
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='submit']"));
            return submit;
        }

       public IWebElement searchBar()
        {
            common.setWait("//*[@id='searchBox']");
            IWebElement searchBar = driver.FindElement(By.XPath("//*[@id='searchBox']"));
            return searchBar;
        }

        public void enterDetails(String fname,String lname,String email,String age,String salary,String dept)
        {
            firstNameTxtBox().Clear();
            firstNameTxtBox().SendKeys(fname);
            lastNameTxtBox().Clear();
            lastNameTxtBox().SendKeys(lname);
            emailTxtBox().Clear();
            emailTxtBox().SendKeys(email);
            ageTxtBox().Clear();
            ageTxtBox().SendKeys(age);
            salaryTxtBox().Clear();
            salaryTxtBox().SendKeys(salary);
            deptTxtBox().Clear();
            deptTxtBox().SendKeys(dept);

        }

        public IWebElement editRecordBtn()
        {
            IWebElement editRecordBtn = driver.FindElement(By.XPath("//*[@title='Edit']"));
            return editRecordBtn;
        }

        public void searchTheRecordUsingName(String name)
        {
            searchBar().Clear();
            searchBar().SendKeys(name);
            IWebElement res = driver.FindElement(By.XPath("//*[text()='" + name + "']"));
            Assert.True(res.Displayed);


        }

        public void clickEditRecordBasedOnName(String name)
        {
            searchTheRecordUsingName(name);
            editRecordBtn().Click();
            firstNameTxtBox().Clear();
            lastNameTxtBox().Clear();
            emailTxtBox().Clear();
            ageTxtBox().Clear();
            salaryTxtBox().Clear();
            deptTxtBox().Clear();

        }


        public void clickSubmit()
        {
            submit().Click();
        }
        









    }
}
