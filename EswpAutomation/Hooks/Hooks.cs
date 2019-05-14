using EswpAutomation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
//using AventStack.ExtentReports.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System.Reflection;

namespace EswpAutomation.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        //Global Variable for Extend report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"C:\extentreport\SeleniumWithSpecflow\SpecflowParallelTest\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new ExtentReports();


            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
         //   BrowserFactory.CloseAllDrivers();

        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

       //     PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
      //      MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
     //       object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending Status
       /*     if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }*/

        }


        [BeforeScenario]
        public void Initialize()
        {
            BrowserFactory.InitBrowser("IE");
           // BrowserFactory.LoadApplication("https://eswp-pt2.azurewebsites.net/");
            BrowserFactory.LoadApplication("https://eswppt.azurewebsites.net/");
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void CleanUp()
        {
        }








































































        // private static KlovReporter klov;

        /* private static ExtentTest featureName;
         private static ExtentTest scenario;
         private static AventStack.ExtentReports.ExtentReports extR;


         [BeforeTestRun]
         public static void InitializeReport()
         {
             var htmlReporter = new ExtentV3HtmlReporter("C:\\Users\\madhavi.itikirala\\Documents\\Visual Studio 2017\\Projects\\EswpAutomation\\EswpAutomation\\ExtentReport.html");
             htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
             var extR = new AventStack.ExtentReports.ExtentReports();
             extR.AttachReporter(htmlReporter);
         }

         [AfterTestRun]
         public static void TearDownReport()
         {
             extR.Flush();
         }


         [BeforeScenario]
         public void BeforeScenario()
         {
             scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
             BrowserFactory.InitBrowser("Chrome");
             BrowserFactory.LoadApplication("https://eswp-pt2.azurewebsites.net/");

         }


         [AfterScenario]
         public void AfterScenario()
         {
             BrowserFactory.CloseAllDrivers();

         }






         [BeforeFeature()]
         public static void BeforeFeature()
         {
             featureName = extR.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

         }



        [AfterStep]
         public void InsertReportingSteps()
         {
             scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
         }




         //   [AfterScenario()]
       //  [AfterFeature()]
         public static void AfterScnario()
         {
             if (ScenarioContext.Current.TestError != null)
             {
                 var error = ScenarioContext.Current.TestError;
                 var errormessage = "<pre>" + error.Message + "</pre>";
                 //Add capture screen shot line here

                 //  extent.EndTest(test);

             }
         }

         // [AfterFeature()]
         public static void EndReport()
         {
             //  extent.Flush();
             // extent.Close();
         }*/

    }
}
