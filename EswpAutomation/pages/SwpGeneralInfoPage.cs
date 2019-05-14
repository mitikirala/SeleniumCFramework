using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EswpAutomation.pages
{
    public class SwpGeneralInfoPage
    {

        public SwpGeneralInfoPage()
        {
            
        }


        [FindsBy(How = How.XPath, Using = "//textarea[@id='Description']")]
        public IWebElement receiverModal;


        [FindsBy(How = How.XPath, Using = "//a[@class='btn dropdown-toggle']")]
        public IWebElement roleDdn;

      










    }
}
