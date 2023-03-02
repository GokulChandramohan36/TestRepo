using DemoQA.PageElements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoQA.StepDefinition
{
    [Binding]
    public class Interactions
    {
        InteractionsPage interact = new InteractionsPage();
        [Then(@"I see Sortable page in the menu")]
        public void ThenISeeSortablePageInTheMenu()
        {
            interact.verifyIfSortablePageIsPresent();
        }

        [When(@"I click on the Sortable page")]
        public void WhenIClickOnTheSortablePage()
        {
            interact.clickSortablePage();
        }

        [Then(@"I see list of sortable items")]
        public void ThenISeeListOfSortableItems()
        {
            interact.verifyIfListIsPresent();
        }

        [Then(@"I sort them all in descending order")]
        public void ThenISortThemAllInDescendingOrder()
        {
            interact.sortListElementsDESC();
        }

        [Then(@"I click on grid")]
        public void ThenIClickOnGrid()
        {
            interact.gridSortable().Click();
        }

        [Then(@"I sort the grid in desc order")]
        public void ThenISortTheGridInDescOrder()
        {
            interact.sortGridElementsDESC();
        }

        [Then(@"I see droppable Page in the Menu")]
        public void ThenISeeDroppablePageInTheMenu()
        {
            Assert.True(interact.droppablePage().Displayed);
        }

        [When(@"I click on the droppable page")]
        public void WhenIClickOnTheDroppablePage()
        {

            interact.droppablePage().Click();
        }

        [Then(@"I validate the drag and drop functionality")]
        public void ThenIValidateTheDragAndDropFunctionality()
        {
            interact.simpleDragAndDrop();
            interact.verifyDragAndDrop();
            
        }









    }
}
