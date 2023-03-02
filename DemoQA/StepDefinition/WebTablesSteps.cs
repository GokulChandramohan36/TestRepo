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
    public class WebTablesSteps
    {
        WebTable webTable = new WebTable();


        [When(@"I see webTables page")]
        public void WhenISeeWebTablesPage()
        {
            webTable.isWebTablePageOpen();
        }
        [When(@"I click on add new records button")]
        public void WhenIClickOnAddNewRecordsButton()
        {
            Thread.Sleep(1000);
            webTable.clickAddNewRecords();
        }

        [When(@"I enter the firstname as ""([^""]*)"" lastname as ""([^""]*)"" age as ""([^""]*)"" email as ""([^""]*)"" salary as ""([^""]*)"" department as ""([^""]*)""")]
        public void WhenIEnterTheFirstnameAsLastnameAsAgeAsEmailAsSalaryAsDepartmentAs(string fname, string lname, string age, string email, string salary, string dept)
        {
            webTable.enterDetails(fname, lname, email, age, salary, dept);
        }


        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            webTable.clickSubmit();
        }

        [Then(@"I see the record added as ""([^""]*)"" lastname as ""([^""]*)"" age as ""([^""]*)"" email as ""([^""]*)"" salary as ""([^""]*)"" department as ""([^""]*)""")]
        public void ThenISeeTheRecordAddedAsLastnameAsAgeAsEmailAsSalaryAsDepartmentAs(string fname, string lname, string age, string email, string salary, string dept)
        {
            webTable.searchTheRecordUsingName(fname);
        }

        [When(@"I click on edit record for the name as ""([^""]*)""")]
        public void WhenIClickOnEditRecordForTheNameAs(string targetName)
        {
            webTable.clickEditRecordBasedOnName(targetName);
        }









    }
}
