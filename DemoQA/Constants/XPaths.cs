using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Constants
{
    public class XPaths
    {
        static  XpathLocators locators = new XpathLocators();
        static HomePageConstants home = new HomePageConstants();
        String homePageBottomLabelXpath = "//*[" + locators.text + "," + home.homePageBottomLabel + ")]";
        String ElementLinkXpath = "//" + locators.HeaderLevel5 + "[" + locators.text + "," + home.ElementsLabel + ")]//preceding::div[1]";
    }
}
