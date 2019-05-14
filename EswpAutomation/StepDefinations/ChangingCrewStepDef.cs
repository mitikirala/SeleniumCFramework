using EswpAutomation.pag;
using EswpAutomation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EswpAutomation.StepDefinations
{


    public class ChangingCrewStepDef
    {
        IWebDriver driver;
        /*
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

                   // ScenarioContext.Current.Pending();
                }

                [Given(@"Select Change an Active or Exempt Permit option")]
                public void GivenSelectChangeAnActiveOrExemptPermitOption()
                {

                    driver.FindElement(By.XPath("//*[@id='GotoPage']/ul/li[2]")).Click();
                    Thread.Sleep(5000);
                   // ScenarioContext.Current.Pending();
                }

                [Given(@"Search PermitNumber and Highlight your permit")]
                public void GivenSearchPermitNumberAndHighlightYourPermit()
                {
                    Thread.Sleep(2000);
                    EswpTable table = new EswpTable("PermitProject");
                    IWebElement tr = table.getRowByColumnDetails("Am Sixteen");
                    if (tr == null)
                        throw new Exception("No record found");
                    tr.Click();
                    IJavaScriptExecutor jse = (IJavaScriptExecutor) driver;
                    jse.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", tr, "class", "k-state-selected");

                    Console.WriteLine("BBB");
                    Console.WriteLine(tr);
                    // ScenarioContext.Current.Pending();
                }

                [Given(@"click on the ChangeCrew Icon")]
                public void GivenClickTheChangeCrewIcon()
                {

                    ScenarioContext.Current.Pending();
                }

                [Given(@"Make the changes to the crew")]
                public void GivenMakeChangesToTheCrew()
                {
                    ScenarioContext.Current.Pending();
                }

                [Given(@"Verify the Message.")]
                public void GivenVerifyTheSuccessMessage_()
                {
                    ScenarioContext.Current.Pending();
                }
            }
            */
    }
}

