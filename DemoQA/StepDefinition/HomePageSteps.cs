using DemoQA.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoQA.StepDefinition
{
    [Binding]
    public class HomePageSteps
    {
        HomePage home = new HomePage();

        [Given(@"I am in the Home Page")]
        public void GivenIamintheHomePage() 
        {
            home.isHomePageOpen();
        
        }
        [When(@"I click on the widgets link")]
        public void WhenIClickOnTheWidgetsLink()
        {
            home.clickWidgetsLink();
        }


        [When(@"I click on the Elements Link")]
        public void WhenIClickOnTheElementsLink()
        {
            home.ClickElements();
        }

        

        [When(@"I click on AlertFramesWindows Page")]
        public void WhenIClickOnAlertFramesWindowsPage()
        {

            home.clickAlertLink();
        }

        [When(@"I click on Interactions page")]
        public void WhenIClickOnInteractionsPage()
        {
            home.clickInteractionsLink();  
        }






    }



}
