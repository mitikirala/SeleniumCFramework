using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESWPAutomationFramework.Pages
{
   
    public class ReceiverOptionsPage
    {
        public ReceiverOptionsPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[text()[contains(.,'Initial Check-In')]]")]
        public IWebElement txtboxCheckin { get; set; }

        [FindsBy(How = How.XPath, Using = "('//span[contains(text(), 'Change an Active or Exempt Permit')]")]
        public IWebElement txtboxchgpermit;

     }
}
