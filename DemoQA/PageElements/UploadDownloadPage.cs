using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoQA.PageElements
{
    
    public class UploadDownloadPage:driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement downloadBtn()
        {
            IWebElement downloadBtn = driver.FindElement(By.XPath("//*[@id='downloadButton']"));
            return downloadBtn;
        }
        public IWebElement uploadBtn()
        {
            IWebElement uploadBtn = driver.FindElement(By.XPath("//*[@id='uploadFile']"));
            return uploadBtn;
        }

        public void verifyDownloadFile()
        {
            common.scrollToBottom();
            downloadBtn().Click();
            Thread.Sleep(3000);
            String name = downloadBtn().GetAttribute("download");
            Console.WriteLine("name of the file : " + name);
            String path = "C:\\Users\\Gokul.Chandramohan\\Downloads";
            string[] filePaths = Directory.GetFiles(path);



            String downloaded = path +"\\"+ name;
            Console.WriteLine("Downloaded file name : "+downloaded);
            foreach (string p in filePaths)
            {
                Console.WriteLine(p);
                if (p.Contains(name))
                {
                    Assert.True(filePaths.Contains(downloaded));
                }



            }

           


        }
        public IWebElement uploadedFilePath()
        {
            IWebElement uploadedFilePath = driver.FindElement(By.XPath("//*[@id='uploadedFilePath']"));
            return uploadedFilePath;
        }

        public void verifyUploadFile()
        {
            String file = "C:\\Users\\Gokul.Chandramohan\\Downloads\\sampleFile.jpeg";
            String[] dummy = file.Split("\\");
            String filename = dummy.Last();
            Console.WriteLine("FileName is :" + filename);
            Thread.Sleep(3000);
            //common.dynamicClickOnElement(uploadBtn());
            uploadBtn().SendKeys(file);
            String uploadedFile = uploadedFilePath().Text;
            Console.WriteLine("The uploaded path name is :" + uploadedFile);
            Assert.That(uploadedFile.Contains(filename));

        }

    }
}
