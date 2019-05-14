using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EswpAutomation.pages
{
   public  class HarzadeousPage
    {



        public HarzadeousPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Hazard Analysis')]")]
        public IWebElement tabHazardAnalysis;

 [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Save Hazard Analysis')]")]
        public IWebElement SaveHazardAnalysisBtn;
    
}
}
