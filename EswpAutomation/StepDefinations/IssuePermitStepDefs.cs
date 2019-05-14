using System;
using TechTalk.SpecFlow;
using EswpAutomation.pag;
using EswpAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;
using EswpAutomation.pages;
using System.Diagnostics;
using ESWPAutomationFramework.Pages;
using OpenQA.Selenium.Interactions;

namespace EswpAutomation.StepDefinations
{
 
namespace MyNamespace
    {
        [Binding]
        public class IssuePermitStepDefs
        {
            IWebDriver driver = BrowserFactory.driver;

            [Given(@"User Navigates SWP Modal")]
            public void GivenUserNavigatesSWPModal()
            {

                LandingPage landingpg = new LandingPage();
                landingpg.swpModal.Click();
                driver.FindElement(By.Id("otherTile")).Click();
               // driver.FindElement(By.ClassName("tile app bg - color - red")).Click();
                //tile app bg - color - red
                MSAuthPage msAuthPg = new MSAuthPage();
                Thread.Sleep(1000);
                msAuthPg.authMicroSoft.SendKeys("ND63257@DOW.com");
                Thread.Sleep(2000);
                msAuthPg.authBtnNext.Click();
                Thread.Sleep(6000);
                Process.Start("C:\\Users\\madhavi.itikirala\\Desktop\\AutoitScripts\\HandleWinAuth.exe");
                Thread.Sleep(10000);


                //Selecting the role of issuer

                NewSWPPage newSWPPage = new NewSWPPage();
                Thread.Sleep(3000);
                newSWPPage.roleDdn.Click();
                Thread.Sleep(2000);
                newSWPPage.role.Click();
               



                
            }

            [Given(@"Select the New permit Task with (.*)")]
            public void GivenSelectTheNewPermitTaskWith(string p0)
            {
                Thread.Sleep(6000);

                EswpTable tbl = new EswpTable("gridRequestList");
                  IWebElement row = tbl.getRowByColumnDetails(11, p0);
                 IWebElement taskTd  = row.FindElement(By.XPath(".//td[7]/a"));
                taskTd.Click();
               // IWebElement td = tbl.getAnchorColumnByColumnDetails(p0);
                if (taskTd == null)
                    throw new Exception("No record found");
                // ScenarioContext.Current.;
                //td.Click();
                Thread.Sleep(3000);
                NewSWPPage newSWPPage = new NewSWPPage();
                Thread.Sleep(4000);
                newSWPPage.txtScopeOfWork.Clear();
                newSWPPage.txtScopeOfWork.SendKeys("Test");
             

                newSWPPage.btnSaveTask.Click();
                Thread.Sleep(2000);
                try
                {
                    if (driver.FindElement(By.Id("btnReceiverSummonedAlertYes")) != null)
                    {
                        Boolean flag = true;
                        int i = 0;
                        while (!driver.FindElement(By.Id("btnReceiverSummonedAlertYes")).Displayed)
                        {
                            Thread.Sleep(1000);
                            i++;
                            if (i == 5)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            SummonPage summonpage = new SummonPage();
                            summonpage.alertYes.Click();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                Thread.Sleep(5000);
                try
                {
                    driver.SwitchTo().Alert().Accept();
                }catch(Exception e)
                {

                }


                             
                Thread.Sleep(8000);
                WorkTypePage workTypePage = new WorkTypePage();
                workTypePage.btnWorkType.Click();
                workTypePage.btnSaveMatrix.Click();
                Thread.Sleep(6000);
                try
                {
                    if (driver.FindElement(By.Id("btnAlertArrived")) != null)
                    {
                        Boolean flag = true;
                        int i = 0;
                        while (!driver.FindElement(By.Id("btnAlertArrived")).Displayed)
                        {
                            Thread.Sleep(1000);
                            i++;
                            if (i == 5)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            ArriveConfirmationPage arriveConfirmationPage = new ArriveConfirmationPage();
                            arriveConfirmationPage.aArrivedYes.Click();
                            Thread.Sleep(2000);
                        }

                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                try
                {
                    driver.SwitchTo().Alert().Accept();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                                              
                Thread.Sleep(6000);
                HarzadeousPage harzadeous = new HarzadeousPage();
                harzadeous.tabHazardAnalysis.Click();
                Thread.Sleep(2000);
                harzadeous.SaveHazardAnalysisBtn.Click();
                Thread.Sleep(6000);
                driver.SwitchTo().Alert().Accept();
                Thread.Sleep(6000);

                //Permit Page
                PermitPage permitPage = new PermitPage();
                // Thread.Sleep(3000);
                permitPage.rdBtnScopeOfWorkYes.Click();
               // permitPage.rdBtnScopeNBoundriesYes.Click();
                permitPage.chkBxFacilityOrientationYes.Click();
                permitPage.chkBxEmergencyProcedures.Click();
                 permitPage.rdBtnScopeNBoundriesYes.Click();
                permitPage.rdBtnWorkAreaImpactYes.Click();
                permitPage.rdBtnAdjFacNotifyYes.Click();
                permitPage.rdBtnEquipmentPrepYes.Click();
                permitPage.rdBtnAsbestosInspectionYes.Click();
                permitPage.rdBtnGroundProgramYes.Click();
                permitPage.rdBtnElevatedWorkTriggerYes.Click();
                permitPage.rdBtnSpecialityTrainingYes.Click();
                permitPage.rdBtnAdditionalInfoYes.Click();
                permitPage.rdBtnFieldMonitoringNa.Click();
                permitPage.chkBxBioHazardsDapply.Click();
                permitPage.chkBxChemicalHazardsDApply.Click();
                permitPage.chkBxPhysicalHazardsDapply.Click();
                permitPage.chkEnvConsiderationsDapply.Click();
                permitPage.chkErgoConsiderationsDapply.Click();
                permitPage.chkBarricadesDapply.Click();
                permitPage.chkIoesDapply.Click();

                //Section III SafeWorkPermit Activation
                
                permitPage.rdBtnAllWrkrsListedYes.Click();
                permitPage.rdReviewedContentsYes.Click();
                permitPage.chkScopeNRequirementsYes.Click();
                permitPage.chkIoeNeedToNotifyYes.Click();
                permitPage.chkNecessarySkillsYes.Click();
                permitPage.chkNnUsYes.Click();
                permitPage.chkReviewedSWPYes.Click();
                permitPage.chkOnsiteInspectionYes.Click();
                permitPage.rdBtnOnSiteInspNeededAreNot.Click();
                permitPage.rdBtnCloseOutInspNeededIsNot.Click();
              //  permitPage.rdBtnCloseOutInspNeededIs.Click();
                permitPage.rdBtnJointEquNotifyOwnersNa.Click();
                permitPage.rdBtnAdjFacNotifyNa.Click();
              //  permitPage.rdBtnCrewRoasterAttachedYes.Click();

                //Signatures

                Thread.Sleep(4000);
                permitPage.imgRecSignature.Click();
                DrawSignature();
                permitPage.btnApplyCurrentSignature.Click();
                Thread.Sleep(1000);
                permitPage.imgIssuerSignature.Click();
                Thread.Sleep(1000);
                DrawSignature();
                permitPage.btnApplyCurrentSignature.Click();


                //Signature Times
                              
                DateTime currentTime = DateTime.Now;
                DateTime x30MinsLater = currentTime.AddMinutes(20);
                permitPage.calStartDateTime.SendKeys(currentTime.ToString("yyyy'/'MM'/'dd' 'HH':'mm"));
                permitPage.calEndDateTime.SendKeys(x30MinsLater.ToString("yyyy'/'MM'/'dd' 'HH':'mm"));
                permitPage.btnIssuePermit.Click();

                Thread.Sleep(2000);
                driver.SwitchTo().Alert().Accept();
                driver.FindElement(By.XPath("//input[@value='Email ' and @id='btnPrint']")).Click();

            /*    driver.FindElement(By.Id("txtEmailReceivers")).SendKeys("mitikirala@dow.com");
                driver.FindElement(By.XPath("//a[@title='Submit' and @onclick='SendEmail();']")).Click();
                Thread.Sleep(6000);
                driver.SwitchTo().Alert().Accept();

                driver.Url="https://pod51243.outlook.com/owa/?realm=DOW.COM&exsvurl=1&ll-cc=1033&modurl=0&path=/attachmentlightbox";

                driver.Navigate();

                
                 driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/button")).Click();
                 Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/div[1]/div/form/div/input")).SendKeys("1234567890");
                driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/div[1]/div/button[1]")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//div[@autoid='_lvv_3' and contains(string(), '1234567890')]")).Click();
                 Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='Item.MessageUniqueBody']/div/div/p[2]/a")).Click();
                */
   

             }

            public void DrawSignature()
            {

                IWebElement elem = driver.FindElement(By.XPath("//*[@id='eSignaturePanel_permit']/canvas"));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(elem).MoveByOffset(10, 10).
                MoveByOffset(18, 10).Click();
                //   driver.Manage().Timeouts().ImplicitWait(10, TimeSpan.FromSeconds);
                builder.ClickAndHold(elem).MoveByOffset(-10, -15).DoubleClick().MoveByOffset(18, 20).MoveByOffset(-22, -17).DoubleClick().Click()
                .Build().Perform();
            }

            [Given(@"Select the New permit Task")]
            public void GivenSelectTheNewPermitTask()
            {
             
              //  ScenarioContext.Current.Pending();
            }

            [Given(@"enters the details for work, harardeous materials and permit")]
            public void GivenEntersTheDetailsForWorkHarardeousMaterialsAndPermit()
            {
               // ScenarioContext.Current.Pending();
            }

            [Given(@"Issues the permit\.")]
            public void GivenIssuesThePermit_()
            {
                ScenarioContext.Current.Pending();
            }

            [Given(@"Selects Change an Active or Exempt Permit option")]
            public void GivenSelectsChangeAnActiveOrExemptPermitOption()
            {
                ScenarioContext.Current.Pending();
            }

            [Given(@"Search your PermitNumber and Highlight your permit")]
            public void GivenSearchYourPermitNumberAndHighlightYourPermit()
            {
                ScenarioContext.Current.Pending();
            }

        
        }
    }

   






}
