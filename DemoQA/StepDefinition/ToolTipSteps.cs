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
    public class ToolTipSteps
    {
        ToolTipPage tool = new ToolTipPage();
        

        [Then(@"I validate all the tool tips")]
        public void ThenIValidateAllTheToolTips()
        {
            
            
        }

        [Then(@"I validate the button tool tip")]
        public void ThenIValidateTheButtonToolTip()
        {
            tool.getToolTipInfo();
        }

        [Then(@"I validate the text tool tip")]
        public void ThenIValidateTheTextToolTip()
        {
            tool.getTextToolTipInfo();
        }




    }
}
