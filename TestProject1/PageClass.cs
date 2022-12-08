
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

public class pageClass
{
	IWebDriver _driver;
	IWebElement searchBar;
	
	public pageClass(IWebDriver driver) 
	{
		_driver = driver;
	}

	public void enterText(string text)
	{
		searchBar = _driver.FindElement(By.XPath("//input[@title=\"Search\"]"));
		searchBar.Click();
		searchBar.SendKeys(text);
	}

	public void pressEnter()
	{
		searchBar.SendKeys(Keys.Enter);
	}


	
	
}
