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
    public class AlertFramesWindowsStep
    {
        AlertFramesWindowsPage alw = new AlertFramesWindowsPage();

        [When(@"I see list of elements in the AlertFramesWindows Menu")]
        public void WhenISeeListOfElementsInTheAlertFramesWindowsMenu()
        {
            alw.areAllElementsPresentInTheList();
        }

        [When(@"I click on browser windows")]
        public void WhenIClickOnBrowserWindows()
        {
            alw.clickBrowserWindows();
        }

        [When(@"I click on Alerts")]
        public void WhenIClickOnAlerts()
        {
            alw.clickAlerts();
        }






    }
}
