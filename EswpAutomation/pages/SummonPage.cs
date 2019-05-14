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
    public class SummonPage
    {
        public SummonPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        [FindsBy(How = How.Id, Using = "btnReceiverSummonedAlertYes")]
        public IWebElement alertYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'SummonedAlertYes']")]
        public IWebElement alertNo;
    }
}
