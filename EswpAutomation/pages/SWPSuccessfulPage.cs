using EswpAutomation.Utils;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESWPAutomationFramework.Pages
{
    class SWPSuccessfulPage
    {
        public SWPSuccessfulPage()
        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }
    }
}
