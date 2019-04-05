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
    class PermitNotListedModalComponent
    {
        public PermitNotListedModalComponent()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }

        #region PageObjects

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Receiver Portal')]")]
        public IWebElement ddnTaskType;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Safe Work Permit')]")]
        public IWebElement txtPoNo;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Administration')]")]
        public IWebElement txtTaskName;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'External Task Form')]")]
        public IWebElement ddnPriority;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Reports')]")]
        public IWebElement txtEquipName;


        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Receiver DashBoard')]")]
        public IWebElement txtBadgeNo;
        #endregion


        public void AddTask()
        {
            //method to add a worker

        }

        




    }
}
