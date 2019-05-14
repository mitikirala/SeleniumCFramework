using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ESWPAutomationFramework.Pages
{
    class PMSearchPage
    {
      

       public PMSearchPage()
        {

            PageFactory.InitElements(BrowserFactory.driver, this);

        }
        

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkOrder1']")]
        public IWebElement inputPMNO;
               

        // moved from search component

        [FindsBy(How = How.Id, Using = "WorkOrder1")]
        public IWebElement inpPmNumber { get; set; }

        [FindsBy(How = How.Id, Using = "btnNewPermit")]
        public IWebElement btnNewPermit { get; set; }

        [FindsBy(How = How.Id, Using = "drpTaskType")]
        public IWebElement ddnTaskType { get; set; }

       // [FindsBy(How = How.Id, Using = "drpTaskType")]
      //  public IWebElement drpTaskType { get; set; }




        [FindsBy(How = How.Id, Using = "TaskName")]
        public IWebElement inputTaskName { get; set; }

        [FindsBy(How = How.Id, Using = "TaskPriority")]
        public IWebElement lstTaskPriority { get; set; }

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


        [FindsBy(How = How.Id, Using = "addTaskA")]
        public IWebElement addTaskA { get; set; }




        public void SearchPmNumber(String PMNumber)
        {
            inpPmNumber.SendKeys(PMNumber);
            Thread.Sleep(8000);
            // IWebDriver driver = BrowserFactory.driver;

            EswpTable tbl = new EswpTable("ServiceGeneralTask");
            Thread.Sleep(2000);
            IWebElement row=  tbl.getRowByColumnDetails(1, PMNumber);
            Thread.Sleep(2000);
            if (row == null)
            {
                Thread.Sleep(2000);
                btnNewPermit.Click();
                Thread.Sleep(10000);

            }



        }

        public void EnterNewTaskDetails()
        {

            SelectElement drpTaskType = new SelectElement(ddnTaskType);
            drpTaskType.SelectByText("Capital Project");
            inputTaskName.SendKeys("Auto Four");
            SelectElement TaskPriority = new SelectElement(lstTaskPriority);
            TaskPriority.SelectByText("E/P1 Urgent");
            FunctionalLocation.SendKeys("Test Location");
            BadgeNo.SendKeys("1");
            btnAddcrew.Click();
            Thread.Sleep(5000);
            companyName.Click();
            Thread.Sleep(5000);
            companyNameVal.Click();
                           

            Thread.Sleep(2000);
            // TaskFooterComponent footer = new TaskFooterComponent();
            addTaskA.Click();
           // footer.addTaskA.Click();
            Thread.Sleep(2000);
           // driver.FindElement(By.XPath("//*[@id='GetPermitMessageDialog']/div[3]/button")).Click();

        }

        public void EnterNewTaskDetails1(string TaskName)
        {

            SelectElement drpTaskType = new SelectElement(ddnTaskType);
            drpTaskType.SelectByText("Capital Project");
            inputTaskName.SendKeys(TaskName);
            SelectElement TaskPriority = new SelectElement(lstTaskPriority);
            TaskPriority.SelectByText("E/P1 Urgent");
            FunctionalLocation.SendKeys("Test Location");
            BadgeNo.SendKeys("1");
            btnAddcrew.Click();
            Thread.Sleep(5000);
            companyName.Click();
            Thread.Sleep(5000);
            companyNameVal.Click();


            Thread.Sleep(2000);
            // TaskFooterComponent footer = new TaskFooterComponent();
            addTaskA.Click();
            // footer.addTaskA.Click();
            Thread.Sleep(2000);
            // driver.FindElement(By.XPath("//*[@id='GetPermitMessageDialog']/div[3]/button")).Click();

        }





    }

}
