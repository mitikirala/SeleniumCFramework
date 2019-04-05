using EswpAutomation.pages;
using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using SpecFlowIntro.Pages;
//using SpecFlowIntro.WrapperFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using EswpAutomation.pag;
using ESWPAutomationFramework.Pages;

namespace EswpAutomation.StepDefinations
{



    [Binding]
    public  class StepDefinition : Component
    {

       // SearchComponent s = new SearchComponent();
        PMSearchPage pmSearchPage = new PMSearchPage();
        IWebDriver driver = BrowserFactory.driver;
       
        [Given(@"User Navigates to the PMSearchPage from Receviers Modal")]
        public void GivenUserNavigatesToThePMSearchPageFromReceviersModal()
        {
                                                                       
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            LandingPage landingPage = new LandingPage();
            Console.WriteLine("aaaaaa");
            Thread.Sleep(2000);
            landingPage.NagivagetoWelcomePage();

            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("lblPlantNameId")).Click();
            Thread.Sleep(5000);

           
        }

        [Given(@"User enters a (.*)")]
        public void GivenUserEntersAPMNumber(String PMNumber)
        {
            ReceiverOptionsPage recOptionsPage = new ReceiverOptionsPage();
            recOptionsPage.txtboxCheckin.Click();
            Thread.Sleep(1000);
            PMSearchPage pmSearchPage = new PMSearchPage();
            pmSearchPage.SearchPmNumber(PMNumber);
          
            
        }

        [When(@"no results are retrived user clicks on MyPermitisNotListed")]
        public void WhenNoResultsAreRetrivedUserClicksOnMyPermitisNotListed()
        {
           pmSearchPage.EnterNewTaskDetails();
                     
        }

        [When(@"User Submits the Task Details")]
        public void WhenUserSubmitsTheTaskDetails()
        {

         //   Thread.Sleep(2000);
         //   TaskFooterComponent footer = new TaskFooterComponent();
         //   footer.addTaskA.Click();
         //   Thread.Sleep(2000);
         //   driver.FindElement(By.XPath("//*[@id='GetPermitMessageDialog']/div[3]/button")).Click();



        }

        [Then(@"A permit is created with status New Permit")]
        public void ThenAPermitIsCreatedWithStatusNewPermit()
        {
           
        }
    }
}
