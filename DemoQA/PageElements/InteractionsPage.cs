using DemoQA.CommonMethods;
using DemoQA.Constants;
using DemoQA.DriverSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.PageElements
{
    public class InteractionsPage : driverSetup
    {
        static XpathLocators locators = new XpathLocators();
        CommonFunctions common = new CommonFunctions();

        public IWebElement sortablePage()
        {

            IWebElement sortablePage = driver.FindElement(By.XPath("//*[text()='Sortable']"));
            return sortablePage;
        }

        public IWebElement droppablePage()
        {
            common.scrollDownABit();
            IWebElement droppablePage = driver.FindElement(By.XPath("//*[text()='Droppable']"));
            return droppablePage;
        }

        public IWebElement listSortable()
        {
            IWebElement listSortable = driver.FindElement(By.XPath("//*[@id='demo-tab-list']"));
            return listSortable;
        }

         public IWebElement gridSortable()
        {
            common.setWait("//*[@id='demo-tab-grid']");
            IWebElement grid = driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));
            return grid;
        }

        public void clickSortablePage()
        {
            common.scrollDownABit();
            sortablePage().Click();
        }

        public void verifyIfSortablePageIsPresent()
        {
            common.scrollDownABit();
            Assert.True(sortablePage().Displayed);
        }

        public void verifyIfListIsPresent()
        {

            Assert.True(listSortable().Displayed);
        }

        public void sortListElementsDESC()
        {
            string[] src = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
            common.scrollDownABit();
            int count = 0;
            for (int i = 5; i > count ; i--)
            {
                IWebElement source = driver.FindElement(By.XPath("//*[text()='" + src[i] + "']"));
                IWebElement des = driver.FindElement(By.XPath("//*[text()='" + src[count] + "']"));
                common.dragAndDrop(source,des);
                

            }
        }


        public void sortGridElementsDESC()
        {
            string[] src = new string[] { "One", "Two", "Three", "Four", "Five", "Six","Seven","Eight","Nine" };
            common.scrollToBottom();
            int count = 1;
            int desCount = 9;
            for (int i = 9; i > 1 ; i--)
            {
                
                IWebElement source = driver.FindElement(By.XPath("//*[@class='create-grid']/div[" + desCount + "]"));
                IWebElement des = driver.FindElement(By.XPath("//*[@class='create-grid']/div["+count+"]"));
                Console.WriteLine("//*[@class='create-grid']/div[" + count + "]");
                common.scrollToBottom();
                common.dragAndDrop2(source, des);
                Console.WriteLine(count);
                count++;
                
                

            }
        }

        public IWebElement srcElement()
        {
            IWebElement srcElement = driver.FindElement(By.XPath("//*[@id='draggable']"));
            return srcElement;
        }

        public IWebElement destElement() 
        {
            IWebElement destElement = driver.FindElement(By.XPath("(//*[@id='droppable'])[1]"));
            return destElement;
        }

        public void simpleDragAndDrop()
        {
            common.setWait("//*[@id='draggable']");
            common.dragAndDropEle(srcElement(), destElement());
        }

        public void verifyDragAndDrop()
        {
            common.setWait("//*[text()='Dropped!']");
            IWebElement res = driver.FindElement(By.XPath("//*[text()='Dropped!']"));
           
            Assert.True(res.Displayed);
        }













    }
}
