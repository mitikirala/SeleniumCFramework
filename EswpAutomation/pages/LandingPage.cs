using EswpAutomation.Utils;
using ESWPAutomationFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EswpAutomation.pag
{
    class LandingPage
    {

        //completed adding objects

       public LandingPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }


     
        #region PageObjects

        [FindsBy(How = How.XPath, Using = "//*[@id='Div2']/a[2]")]
        public IWebElement receiverModal;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Safe Work Permit')]")]
        public IWebElement swpModal;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Administration')]")]
        public IWebElement adminModal;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'External Task Form')]")]
        public IWebElement taskModal;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Reports')]")]
        public IWebElement reportsModal;

        [FindsBy(How = How.XPath, Using = "('//h4[contains(text(), 'Receiver DashBoard')]")]
        public IWebElement dbModal;




         [FindsBy(How = How.XPath, Using = "//*[@id='divTenantEditBody']/table/tbody/tr[1]/td[2]/span/span/span")]
        public IWebElement ddnSitesOpen { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SiteIdNO_listbox']/li[text()='2019_StandardTestAndy']")]
        public IWebElement ddnlistSites { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='divTenantEditBody']/table/tbody/tr[2]/td[2]/span/span/span")]
        public IWebElement ddnPlantOpen { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PlantIdNO_listbox']/li[text()='2019_StandardTestAndyPlant']")]
        public IWebElement ddnlistPlant { get; set; }

        [FindsBy(How = How.XPath, Using = "//a/*[text()='OK']")]
        public IWebElement btnOk { get; set; }

        [FindsBy(How = How.Id, Using = "//*[@id='lblPlantNameId']")]
        public IWebElement lblPlantName;

        [FindsBy(How = How.Id, Using = "//span[contains(@class, 'win-commandimage')]")]
        public IWebElement ringPlantOption;

       // win-commandimage win-commandring


        #endregion




        public void NagivagetoWelcomePage()
        {
            receiverModal.Click();
            Thread.Sleep(2000);
          //  lblPlantName.Click();
            selectPlant();
          //  tblCenter.Click();
         
        }




        public void NavigateToReceiverPage()
        {
            this.lblPlantName.Click();


        }


        public void selectPlant()
        {
           // ringPlantOption.Click();
            ddnSitesOpen.Click();
            Thread.Sleep(2000);
            ddnlistSites.Click();
            Thread.Sleep(2000);
            ddnPlantOpen.Click();
            Thread.Sleep(2000);
            ddnlistPlant.Click();
            btnOk.Click();
            Thread.Sleep(2000);
        

        }

        public ReceiverOptionsPage NavigateToReceiverOptionsPage()
        {
             //  new  WelcomePage().Click();
            return new ReceiverOptionsPage();
        }
        public void NavigateToModal(string ModalName)
        {

        }




    }
}
