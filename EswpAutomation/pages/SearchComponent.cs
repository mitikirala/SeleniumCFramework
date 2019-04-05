using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EswpAutomation.pages
{

    
    public sealed class SearchComponent
    {
        public SearchComponent()
        {

            PageFactory.InitElements(BrowserFactory.driver, this);

        }



        #region PageObjects
        [FindsBy(How = How.XPath, Using = "//*[@id='Div2']/a[2]")]
        public IWebElement modalRecPortal { get; set; }

     

        [FindsBy(How = How.Id, Using = "ReceiverPortalMainDivId")]
        public IWebElement Yes { get; set; }

       

        //[FindsBy(How = How.XPath, Using = "//*[@id='ServiceGeneralTask']/div[2]/table/tbody/tr")]
        //  public IWebElement Rows { get; set; }


        [FindsBy(How = How.Id, Using = "WorkOrder1")]
        public IWebElement WorkOrder1 { get; set; }

        [FindsBy(How = How.Id, Using = "btnNewPermit")]
        public IWebElement NewPermit { get; set; }

        [FindsBy(How = How.Id, Using = "drpTaskType")]
        public IWebElement drpTaskType { get; set; }


        [FindsBy(How = How.Id, Using = "TaskName")]
        public IWebElement TaskName { get; set; }

        [FindsBy(How = How.Id, Using = "TaskPriority")]
        public IWebElement TaskPriority { get; set; }

        [FindsBy(How = How.Id, Using = "Exempt")]
        public IWebElement Exempt { get; set; }

        [FindsBy(How = How.Id, Using = "IsCriticalPath")]
        public IWebElement IsCriticalPath { get; set; }

        [FindsBy(How = How.Id, Using = "FunctionalLocation")]
        public IWebElement FunctionalLocation { get; set; }

        [FindsBy(How = How.Id, Using = "BadgeNo")]
        public IWebElement BadgeNo { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddcrew")]
        public IWebElement btnAddcrew { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='tbReceiverInfo']/tr[2]/td[2]/span/span/span[2]")]
        public IWebElement companyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='drpCompanies_listbox']/li[text()='Other - Not Listed']")]
        public IWebElement companyNameVal { get; set; }

       // [FindsBy(How = How.Id, Using = "addTaskA")]
      //  public IWebElement addTaskA { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Submit')]")]
        public IWebElement addTaskA { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='divTenantEditMain']/div[@class='modal-footer']")]
        public IWebElement footerModal { get; set; }
        #endregion



    }
}
