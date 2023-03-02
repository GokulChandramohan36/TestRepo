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
    public class TextBoxSteps
    {
        Textbox txtBox = new Textbox();
        [When(@"I enter the username as ""([^""]*)"" email as ""([^""]*)"" address as ""([^""]*)"" permanentAddress as ""([^""]*)""")]
        public void WhenIEnterTheUsernameAsEmailAsAddressAsPermanentAddressAs(string username, string email, string address, string permAddress)
        {
            txtBox.enterDetails(username,email, address, permAddress);
        }

        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            txtBox.clickSubmit();
        }

        [Then(@"I see the submitted details as ""([^""]*)"" email as ""([^""]*)"" address as ""([^""]*)"" permanentAddress as ""([^""]*)""")]
        public void ThenISeeTheSubmittedDetailsAsEmailAsAddressAsPermanentAddressAs(string username, string email, string address, string permAddress)
        {
            txtBox.validateAllDetails(username, email, address, permAddress);
        }



    }
}
