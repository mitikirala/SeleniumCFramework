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
    public class WorkTypePage
    {
        public WorkTypePage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        [FindsBy(How = How.Id, Using = "decisionMatrixTab")]
        public IWebElement btnWorkType;


        [FindsBy(How = How.XPath, Using = "//a[@id='btnSavePrePlanning']")]
        public IWebElement btnSaveMatrix;

        [FindsBy(How = How.XPath, Using = "btnSaveHazardAnalysis")]
        public IWebElement btnSaveHazardAnalysis;
    }
}
