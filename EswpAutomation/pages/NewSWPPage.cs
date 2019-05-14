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
    class NewSWPPage
    {
        public NewSWPPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='gridRequestList']/div[2]/table/tbody/tr[2]/td[10][contains(text(), 'Administration')]")]
        public IWebElement adminModal;



        [FindsBy(How = How.XPath, Using = "//textarea[@id='Description']")]
        public IWebElement txtScopeOfWork;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='FunctionalLocation']")]
        public IWebElement FunctionalLocation;

        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Save Task')]")]
        public IWebElement btnSaveTask;


        [FindsBy(How = How.XPath, Using = " btnSaveHazardAnalysis")]
        public IWebElement btnSaveHazardAnalysis;

       // btnSaveHazardAnalysis



        [FindsBy(How = How.Id, Using = "logedinUser")]
        public IWebElement roleDdn;



        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']")]
        public IWebElement roleList;


        [FindsBy(How = How.XPath, Using = "//li//a[contains(text(),'Issuer')]")]
        public IWebElement role;


      

        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'BeenSummoned']")]
        public IWebElement modalSummoned;




















        public void selectTaskName(string pmNumber)
        {
            BrowserFactory.driver.FindElement(By.XPath("//*[@id='gridRequestList']/div[2]/table/tbody/tr[2]/td[10][contains(text(), '"+pmNumber+"')]"));

               // driver.FindElement(By.XPath("//*[@id='GetPermitMessageDialog']/div[3]/button")).Click();
        }

    }
}
