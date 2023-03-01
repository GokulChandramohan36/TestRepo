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
    public class CheckBoxSteps
    {
        CheckBox check = new CheckBox();


        [When(@"I click on the values as ""([^""]*)"" checkBox")]
        public void WhenIClickOnTheValuesAsCheckBox(string checkbox)
        {
            check.clickdesiredCheckbox(checkbox);
        }



        [Then(@"I check that the result is value as ""([^""]*)""")]
        public void ThenICheckThatTheResultIsValueAs(string checkbox)
        {
            check.checkTheResult(checkbox);
            Thread.Sleep(4000);
        }







    }
}
