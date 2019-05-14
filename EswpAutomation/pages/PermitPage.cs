using EswpAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EswpAutomation.pages
{
    public class PermitPage
    {
        public PermitPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }

         //ScopeofWorkYes
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'2c8dbe5fcf84')]")]
        public IWebElement rdBtnScopeOfWorkYes;

       // [FindsBy(How = How.XPath, Using = "//input[contains(@id,'bef0dd67-bdc4-4178-bdf9-2c8dbe5fcf84')]")]
       // public IWebElement rdBtnScopeOfWorkYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '0974db810f85')]")]
        public IWebElement rdBtnScopeOfWorkNa;


        //FacilitynSiteOrientation
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '87c6609b30ed')]")]
        public IWebElement chkBxFacilityOrientationYes;



        //EmergencyProcedures
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '8448e7a53a0b')]")]
        public IWebElement chkBxEmergencyProcedures;


        //UnderstandingScopeAndBoundriesYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'BAC789AD4FF2')]")]
        public IWebElement rdBtnScopeNBoundriesYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '05A2756456B8')]")]
        public IWebElement rdBtnScopeNBoundriesNa;

        //04320F5D-D205-4721-BFAA-4B1E558BBA6A


        //WorkAreaImpactYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'4B1E558BBA6A')]")]
        public IWebElement rdBtnWorkAreaImpactYes;

        

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'7C25AB43CA15')]")]
        public IWebElement rdBtnWorkAreaImpactNa;




        //EquipmentPreparationYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '33D381101300')]")]
        public IWebElement rdBtnEquipmentPrepYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'D213CB52D2CD')]")]
        public IWebElement rdBtnEquipmentPrepNa;





        //AsbestosInspectionYes

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'C00759ADCD64')]")]
        public IWebElement rdBtnAsbestosInspectionYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'D58E5FFC6599')]")]
        public IWebElement rdBtnAsbestosInspectionNa;




        //GroundingProgramYes and Na

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '332F10E65152')]")]
        public IWebElement rdBtnGroundProgramYes;

   

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '95F52469F7C3')]")]
        public IWebElement rdBtnGroundProgramNa;




        //ElevatedWorkTriggersYes

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '45B76C4BDAB3')]")]
        public IWebElement rdBtnElevatedWorkTriggerYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '6C4D420D0F69')]")]
        public IWebElement rdBtnElevatedWorkTriggerNa;




        //SpecialityTrainingYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '497b1ead9966')]")]
        public IWebElement rdBtnSpecialityTrainingYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '45c31768c0b6')]")]
        public IWebElement rdBtnSpecialityTrainingNa;



        //AdditionaInformationYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '224a2bcba7d6')]")]
        public IWebElement rdBtnAdditionalInfoYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'b80a57e5be8e')]")]
        public IWebElement rdBtnAdditionalInfoNa;



        //FieldMonitoringYes and Na
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '39c9ae891def')]")]
        public IWebElement rdBtnFieldMonitoringYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '746e2a370bc7')]")]
        public IWebElement rdBtnFieldMonitoringNa;






        //Doesnt Apply section

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '96f98fb2ce12')]")]
        public IWebElement chkBxChemicalHazardsDApply;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '1ce20f9d0a86')]")]
        public IWebElement chkBxPhysicalHazardsDapply;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'27D4A9E3313C')]")]
        public IWebElement chkBxBioHazardsDapply;
        

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '0a3816e30229')]")]
        public IWebElement chkEnvConsiderationsDapply;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'bc509485948e')]")]
        public IWebElement chkErgoConsiderationsDapply;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '6311D7594D28')]")]
        public IWebElement chkBarricadesDapply;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '155126e0a481')]")]
        public IWebElement chkIoesDapply;


        //listed all workers under SWP yes and Na

       [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'FCD3D05F1290')]")]
       public IWebElement rdBtnAllWrkrsListedYes;

      //  [FindsBy(How = How.XPath, Using = "//input[@id='D14CDD66-C13B-4545-8C0F-FCD3D05F1290')]")]
       // public IWebElement rdBtnAllWrkrsListedYes;

        

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '7C073E94F743')]")]
        public IWebElement rdBtnAllWrkrsListedNa;


        //Reviewed contents of SWP Yes and Na

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '693B4B376056')]")]
        public IWebElement rdReviewedContentsYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'A948F04AFD3D')]")]
        public IWebElement rdReviewedContentsNa;


        //confirm workers understand Scope and Requirements, Need to Notify, Necessary Skills
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '3a839ad8c07e')]")]
        public IWebElement chkScopeNRequirementsYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '879b199c9d48')]")]
        public IWebElement chkIoeNeedToNotifyYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'F00F484C4E24')]")]
        public IWebElement chkNecessarySkillsYes;


        //5.NonUsOnly Section
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '463539CC9163')]")]
        public IWebElement chkNnUsYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'A8D0E2F26E16')]")]
        public IWebElement chkReviewedSWPYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '75479B6F52B6')]")]
        public IWebElement chkOnsiteInspectionYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '9E36D8896834')]")]
        public IWebElement rdBtnOnSiteInspNeededAre;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'DE3B1A8F4A56')]")]
        public IWebElement rdBtnOnSiteInspNeededAreNot;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'CF737387FB58')]")]
        public IWebElement rdBtnCloseOutInspNeededIs;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'3E34270746C2')]")]
        public IWebElement rdBtnCloseOutInspNeededIsNot;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'ABD5EDE90A8D')]")]
        public IWebElement rdBtnJointEquNotifyOwnersYes;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'29E80230E287')]")]
        public IWebElement rdBtnJointEquNotifyOwnersNa;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'37BA494D4CE5')]")]
        public IWebElement rdBtnAdjFacNotifyYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'DA27DC61F3B9')]")]
        public IWebElement rdBtnAdjFacNotifyNa;
        






        //  [FindsBy(How = How.XPath, Using = "//input[contains(@id, '5BAB17307445')]")]
        //  public IWebElement rdBtnCrewRoasterAttachedYes;


        [FindsBy(How = How.Name, Using = "redStar")]
        public IWebElement rdBtnCrewRoasterAttachedYes;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id, '5BAB17307445')]")]
        public IWebElement rdBtnCrewRoasterAttachedNa;


        //Receiver Signature image 
        [FindsBy(How = How.XPath, Using = "//img[contains(@id,'199D2AD6E090')]")]
        public IWebElement imgRecSignature;

        [FindsBy(How = How.XPath, Using = "//img[contains(@id,'65CAF27D5E5D')]")]
        public IWebElement imgIssuerSignature;

        [FindsBy(How = How.Id, Using = "btnApplyCurrentSignature")]
        public IWebElement btnApplyCurrentSignature;
        

        [FindsBy(How = How.XPath, Using = "//canvas[@class='jSignature']")]
        public IWebElement canvasSignature;



        [FindsBy(How = How.XPath, Using = "//div[@id=' permitContentTab']")]
        public IWebElement tabPermit;

        // permitContentTab

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'txtStartTime')]")]
        public IWebElement calStartDateTime;


        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'txtEndTime')]")]
        public IWebElement calEndDateTime;

        [FindsBy(How = How.XPath, Using = "//a[contains(@id,'btnIssuePermit')]")]
        public IWebElement btnIssuePermit;

 




    }


}
