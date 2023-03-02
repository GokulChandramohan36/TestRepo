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
    public class BrowserWindowsSteps
    {
        BrowserWindowsPage browserWindow = new BrowserWindowsPage();
        [When(@"I see all the available browser action buttons")]
        public void WhenISeeAllTheAvailableBrowserActionButtons()
        {
            browserWindow.checkAlltheButtons();
        }

        [When(@"I click on new tab button")]
        public void WhenIClickOnNewTabButton()
        {
            browserWindow.clickNewTabBtn();
        }
        [Then(@"I see new tab open")]
        public void ThenISeeNewTabOpen()
        {
            browserWindow.verifyNewTab();
        }


    }
}
