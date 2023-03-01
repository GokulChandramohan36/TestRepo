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
    public class WidgetSteps
    {
        WidgetsPage widget = new WidgetsPage();
        [Then(@"I see the list of elements in widget menu")]
        public void ThenISeeTheListOfElementsInWidgetMenu()
        {
            widget.areAllElementsPresent();
        }

        [When(@"I click on Auto Complete Page")]
        public void WhenIClickOnAutoCompletePage()
        {
            widget.clickAutoComplete();
        }

        [When(@"I click on datePicker page")]
        public void WhenIClickOnDatePickerPage()
        {
            widget.clickDatePicker();
        }




    }
}
