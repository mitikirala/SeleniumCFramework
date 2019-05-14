using EswpAutomation.pag;
using EswpAutomation.pages;
using EswpAutomation.Utils;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace EswpAutomation.StepDefinations
{
    [Binding]
    public class AddCrewStepDefs
    {

        IWebDriver driver;
        String saveMsg = "After entering crew information, visit the Issuer to make sure both copies of the permit are matching and to discuss any Issuer concerns.";


        [Given(@"User Navigates to the ReceiverOptionsPage from Receviers Modal")]

        public void GivenUserNavigatesToTheReceiverOptionsPageFromReceviersModal()
        {

            Console.WriteLine("aaaaaa");
            driver = BrowserFactory.driver;
            LandingPage landingPage = new LandingPage();
            landingPage.NagivagetoWelcomePage();
            Console.WriteLine("aaaaaa");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            landingPage.lblPlantName.Click();
            Console.WriteLine("aaaaaa");
                 

        }



        [Given(@"Select Change an Active or Exempt Permit option")]

        public void GivenSelectChangeAnActiveOrExemptPermitOption()

        {

            driver.FindElement(By.XPath("//*[@id='GotoPage']/ul/li[2]")).Click();
            Thread.Sleep(5000);

           
        }

        [Given(@"Search (.*) and Highlight your permit")]
        public void GivenSearchAndHighlightYourPermit(string permitNumber)
        {
            Thread.Sleep(2000);
            EswpTable table = new EswpTable("PermitProject");
            IWebElement tr = table.getRowByColumnDetails(permitNumber);
            if (tr == null)
                throw new Exception("No record found");
            tr.Click();
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", tr, "class", "k-state-selected");
            Console.WriteLine("BBB");
            Console.WriteLine(tr);

        }



/*
        [Given(@"Search PermitNumber and Highlight your permit")]

        public void GivenSearchPermitNumberAndHighlightYourPermit()

        {

            Thread.Sleep(2000);

            EswpTable table = new EswpTable("PermitProject");

            IWebElement tr = table.getRowByColumnDetails("MI thirty");

            if (tr == null)

                throw new Exception("No record found");

            tr.Click();

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            jse.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", tr, "class", "k-state-selected");



            Console.WriteLine("BBB");

            Console.WriteLine(tr);

            // ScenarioContext.Current.Pending();

        }
        */


        [Given(@"click on the ChangeCrew Icon")]
        public void GivenClickOnTheChangeCrewIcon()
        {
            driver.FindElement(By.Id("aChangeMember")).Click();
            Thread.Sleep(2000);
          
        }

        [Given(@"Make the changes to the crew")]
        public void GivenMakethechangestotheCrew()
        {
            AddCrewPage addCrewPage = new AddCrewPage();
            addCrewPage.aChangeMember.Click();
            Thread.Sleep(2000);
            addCrewPage.btnAddcrew.Click();
            Thread.Sleep(2000);
            int badge = 2;
            while (addCrewPage.IsBadgeExist(badge))
            {
                addCrewPage.btnAddcrewResetPop.Click();
                badge++;
            }
            badge++;
            while (addCrewPage.IsBadgeExist(badge))
            {
                addCrewPage.btnAddcrewResetPop.Click();
                badge++;
            }
            addCrewPage.addCrewCancelBtn.Click();

            if (driver.FindElements(By.XPath("//*[@id='Crewgrid']/table/tbody/tr")).Count == 0)
            {
                throw new Exception("Records not added");
            }
            else
            {
                driver.FindElement(By.XPath("//*[@id='Crewgrid']/table/tbody/tr[1]/td[6]/a")).Click();
            }
            addCrewPage.saveBtn.Click();
            Thread.Sleep(2000);
            if (driver.FindElement(By.XPath("//*[@id='GetPermitDivMsgDialogContent']/h2/p")).Text != saveMsg)
            {
                throw new Exception("Save Msg not matched");

            }
            driver.FindElement(By.XPath("//*[@id='GetPermitMessageDialog']/div[3]/button")).Click();
           
        }

        [Given(@"Verify the Message\.")]
        public void GivenVerifyTheMessage_()
        {
           // ScenarioContext.Current.Pending();
        }
    }
    
}

