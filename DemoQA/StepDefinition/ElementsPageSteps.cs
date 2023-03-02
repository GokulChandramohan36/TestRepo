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
    public class ElementsPageSteps
    {
        ElementsPage elements = new ElementsPage();

        [When(@"I see elements Page")]
        public void WhenISeeElementsPage()
        {
            elements.isElementsPageOpen();
        }

        [Then(@"I see all the elements are present in the Elements menu")]
        public void ThenISeeAllTheElementsArePresentInTheElementsMenu()
        {
            elements.isElementsPageOpen();
            elements.areAllItemsDisplayedInTheMenu();
        }
        [When(@"I click on text Box from the list")]
        public void WhenIClickOnTextBoxFromTheList()
        {
            elements.clickTxtBox();
        }

        [When(@"I click on checkBox from the list")]
        public void WhenIClickOnCheckBoxFromTheList()
        {
            elements.clickCheckBox();
        }

        [When(@"I click on webtables from the list")]
        public void WhenIClickOnWebtablesFromTheList()
        {
            elements.clickWebTables();
        }

        [When(@"I click on buttons page")]
        public void WhenIClickOnButtonsPage()
        {
            elements.clickButtonPage();
        }
        [When(@"I click on upload and download page")]
        public void WhenIClickOnUploadAndDownloadPage()
        {
            elements.clickUploadDownloadPage();

        }















    }
}
