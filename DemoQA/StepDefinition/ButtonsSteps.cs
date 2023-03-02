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
    public class ButtonsSteps
    {
        ButtonsPage button = new ButtonsPage();

        [Then(@"I see all the available buttons")]
        public void ThenISeeAllTheAvailableButtons()
        {
            button.verifyIfAllBtnsArePresent();
        }

        [Then(@"I validate all the buttons")]
        public void ThenIValidateAllTheButtons()
        {
            button.verifyDoubleClick();
            button.verifyRightClick();
            button.verifyDynamicClick();
        }


    }
}
