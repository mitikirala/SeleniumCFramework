using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EswpAutomation.Utils
{
    public class EswpTable
    {
            public IWebElement tableElement;

            public EswpTable(string tableName)
            {
                tableElement = BrowserFactory.driver.FindElement(By.XPath("//*[@id='" + tableName + "']/div[2]/table"));
            }

            public IWebElement getRowByColumnDetails(int columnNumber, string columnData)
            {
            if (tableElement.FindElements(By.XPath(".//tbody/tr")).Count > 0)
            {
                IWebElement td = tableElement.FindElement(By.XPath(".//tbody/tr/td[" + columnNumber + "][contains(text(),'" + columnData + "')]"));
                if (td != null)
                {
                    return td.FindElement(By.XPath("./.."));
                }
            }
            return null;
        }

        public IWebElement getRowByColumnDetails( string columnData)
        {
            if (tableElement.FindElements(By.XPath(".//tbody/tr")).Count > 0)
            {
                IWebElement td = tableElement.FindElement(By.XPath(".//tbody/tr/td[contains(.,'" + columnData + "')]"));
                if (td != null)
                {
                    return td.FindElement(By.XPath("./.."));
                }
            }
            return null;
        }

        public IWebElement getAnchorColumnByColumnDetails(string columnData)
        {
            if (tableElement.FindElements(By.XPath(".//tbody/tr")).Count > 0)
            {
                IWebElement td = tableElement.FindElement(By.XPath(".//tbody/tr/td[contains(.,'" + columnData + "')]"));
                if (td != null)
                {
                    return td.FindElement(By.XPath(".//a"));
                }
            }
            return null;
        }

    }
}




