using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESWPAutomationFramework.Pages
{
    public class WelcomePage
    {

       public WelcomePage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        #region PageObjects
        [FindsBy(How = How.Id, Using = "//*[@id='lblPlantNameId']")]
        public IWebElement lblPlantName;
        #endregion

        public void NavigateToReceiverPage()
        {
            this.lblPlantName.Click();


        }
        
    }
}
