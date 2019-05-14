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
    public class MSAuthPage
    {

        public MSAuthPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
        }
        // [FindsBy(How = How.XPath, Using = "//div[contains(text(),'DOW')")]
        // public IWebElement authMicroSoft;

        [FindsBy(How = How.XPath, Using = "//Input[@type='email']")]
        public IWebElement authMicroSoft;
       

        [FindsBy(How = How.XPath, Using = "//input[@id='idSIButton9']")]
        public IWebElement authBtnNext;



    }
}
