
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using TestProject1.Xpath;
using TestProject1;
using NUnit.Framework;

public class pageClass
{
	IWebDriver _driver;
	homePage homeObject;

    public pageClass(IWebDriver driver)
    {
        _driver = driver;
	}



   
    public void enterText(string text)
	{

        homeObject = new homePage(_driver);
        homeObject.searchBar().Click();
		homeObject.searchBar().SendKeys(text);
		homeObject.searchBar().SendKeys(Keys.Enter);
		
	}


	public void clickFaceBookLink()
	{
        homeObject = new homePage(_driver);
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(10));
		wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),\"Facebook - log in or sign up\")]")));

		//Assert.Contains()
		homeObject.targetElement().Click();
		
		//SelectElement dropdown1 = new SelectElement(targetElement);

		
	}

	public void clickCreateNewAccount()
	{

		homeObject = new homePage(_driver);
		Assert.That((_driver.Title),Is.EqualTo(homeObject.facebookPageTitle));
		homeObject.createNewAccount().Click();
		Thread.Sleep(1000);
		
	}




	
	
}
