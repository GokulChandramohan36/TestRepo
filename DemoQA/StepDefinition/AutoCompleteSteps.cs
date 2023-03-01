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
    public class AutoCompleteSteps
    {
        AutoCompletePage    auto = new AutoCompletePage();
        [Then(@"I see auto complete search boxes")]
        public void ThenISeeAutoCompleteSearchBoxes()
        {
            auto.aretheSearchBoxesPresent();
        }
        [Then(@"I verify the Multiple search boxes using ""([^""]*)"" and ""([^""]*)""")]
        public void ThenIVerifyTheMultipleSearchBoxesUsingAnd(string value1, string value2)
        {
            auto.enterMultipleColors(value1, value2);
        }


        [Then(@"I verify the single search Box using ""([^""]*)""")]
        public void ThenIVerifyTheSingleSearchBoxUsing(string value)
        {
            auto.enterSingleColor(value);   
        }



    }
}
