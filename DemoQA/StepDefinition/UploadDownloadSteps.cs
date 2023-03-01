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
    public class UploadDownloadSteps
    {
        UploadDownloadPage updown = new UploadDownloadPage();

        [Then(@"I download the file")]
        public void ThenIDownloadTheFile()
        {
            updown.verifyDownloadFile();
        }

        [Then(@"I upload the file")]
        public void ThenIUploadTheFile()
        {
            updown.verifyUploadFile();
        }



    }
}
