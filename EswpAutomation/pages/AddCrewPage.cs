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
    public class AddCrewPage
    {



        public AddCrewPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }

        [FindsBy(How = How.Id, Using = "aChangeMember")]
        public IWebElement aChangeMember;


        [FindsBy(How = How.Id, Using = "btnAddcrew")]
        public IWebElement btnAddcrew;


        [FindsBy(How = How.Id, Using = "txtMemberNumber")]
        public IWebElement txtMemberNumber;


        [FindsBy(How = How.Id, Using = "btnAddcrewPop")]
        public IWebElement btnAddcrewPop;


        [FindsBy(How = How.Id, Using = "btnAddCrewMemberInfo")]
        public IWebElement btnAddCrewMemberInfo;


        [FindsBy(How = How.XPath, Using = "//*[@id='divPopCrew']/div[4]/a[1]")]
        public IWebElement addCrewCancelBtn;


        [FindsBy(How = How.XPath, Using = "//*[@id='divCrewMember']/div[3]/div/a[2]")]
        public IWebElement saveBtn;

        [FindsBy(How = How.Id, Using = "txtMemberFirstName")]
        public IWebElement txtMemberFirstName;


        [FindsBy(How = How.Id, Using = "txtMemberLastName")]
        public IWebElement txtMemberLastName;

        [FindsBy(How = How.Id, Using = "divPopCrewerrorMsg")]
        public IWebElement divPopCrewerrorMsg;

        [FindsBy(How = How.Id, Using = "btnAddcrewResetPop")]
        public IWebElement btnAddcrewResetPop;


        public Boolean IsAlertExist(Boolean reset)
        {
            try
            {
                BrowserFactory.driver.SwitchTo().Alert().Accept();
                if (reset)
                    this.btnAddcrewResetPop.Click();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Boolean IsBadgeExist(int badgeNo)
        {
            this.txtMemberNumber.SendKeys("" + badgeNo);
            this.btnAddcrewPop.Click();
            IsAlertExist(false);
            this.txtMemberFirstName.Clear();
            this.txtMemberFirstName.SendKeys("MI");
            this.txtMemberLastName.Clear();
            this.txtMemberLastName.SendKeys("MI Lastname " + badgeNo);
            this.btnAddCrewMemberInfo.Click();
            if (IsAlertExist(true))
                return false;
            if (this.divPopCrewerrorMsg.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
