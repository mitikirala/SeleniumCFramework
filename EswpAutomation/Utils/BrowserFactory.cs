using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EswpAutomation.Utils
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        public static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", driver);
                    }
                    break;

                case "IE":
                    if (driver == null)
                    {

                        // Set capability of IE driver to Ignore all zones browser protected mode settings.
                       
                        InternetExplorerOptions opts = new InternetExplorerOptions();
                        opts.EnableNativeEvents = false;
                        opts.IgnoreZoomLevel = true;
                        driver = new InternetExplorerDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..") + "\\resources\\IEDriver",opts);
                        Drivers.Add("IE", driver);
                    }
                    break;

                case "Chrome":
                    if (driver == null)
                    {
                       // driver = new ChromeDriver(@".\..\ChromeDriver");
                        driver = new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")+"\\resources\\ChromeDriver");
                        Drivers.Add("Chrome", driver);
                        Console.WriteLine("Opened the driver from BrowserFactory");
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

    }
}
