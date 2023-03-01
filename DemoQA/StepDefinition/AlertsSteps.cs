using DemoQA.PageElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoQA.StepDefinition
{
    [Binding]
    public class AlertsSteps
    {
        AlertsPage alert = new AlertsPage();
        [Then(@"I validate the Alert dialogs")]
        public void ThenIValidateTheAlertDialogs()
        {
            alert.verifyAlertsWithConfirmation();
            alert.verifyPromptAlert();
        }

    }
}
