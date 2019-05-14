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
    public class ArriveConfirmationPage
    {
        public ArriveConfirmationPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }


        [FindsBy(How = How.Id, Using = "btnAlertArrived")]
        public IWebElement aArrivedYes;

        [FindsBy(How = How.Id, Using = "btnAlertNotArrived")]
        public IWebElement aArrivedNo;
    }
}
