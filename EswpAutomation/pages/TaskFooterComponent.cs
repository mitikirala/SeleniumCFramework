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
    public class TaskFooterComponent
    {
        public TaskFooterComponent()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);



        }

         [FindsBy(How = How.Id, Using = "addTaskA")]
        public IWebElement addTaskA { get; set; }

        #region PageObjects
       // [FindsBy(How = How.XPiath, Using = "//span[contains(text(), 'Submit')]")]
       // public IWebElement addTaskA { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'Test')]")]
        public IWebElement footerModal { get; set; }
        #endregion
    }
}
