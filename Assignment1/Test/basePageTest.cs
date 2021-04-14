using Assignment1.Helper;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment1.Test
{
    class basePageTest
    {
        public static AventStack.ExtentReports.ExtentReports Reporter = new AventStack.ExtentReports.ExtentReports();
        public static ExtentTest _test;
        ExtentHtmlReporter htmlReporter;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            try
            {
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");
                htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                Reporter.AddSystemInfo("Environment", "Automation Practice");
                Reporter.AddSystemInfo("User Name", "Mina");
                Reporter.AttachReporter(htmlReporter);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
            [SetUp]
        public void BeforeTestMethod()

        {
            _test = Reporter.CreateTest(TestContext.CurrentContext.Test.Name);
            // string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\driver");
            // FrameworkHelper.WebDriver = new ChromeDriver(path);
            FrameworkHelper.WebDriver = new ChromeDriver(@"C:\Driver\chromedriver_win32");
            FrameworkHelper.wait = new WebDriverWait(FrameworkHelper.WebDriver, TimeSpan.FromSeconds(30));


            NavigeteToUrl();

        }
        public void NavigeteToUrl()
        {
            FrameworkHelper.WebDriver.Url = "http://demo.guru99.com/test/newtours/";
        }
        [TearDown]
        public void AfterTestMethod()
        {
            string result = TestContext.CurrentContext.Result.Outcome.ToString();

            if (result.Contains("Failed"))
            {
                // convert webDriver object to takescreenShot
                ITakesScreenshot screenshotDriver = (ITakesScreenshot)FrameworkHelper.WebDriver;
                // call getScreenShot as method to create emage file
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\");
                string testName = TestContext.CurrentContext.Test.Name;
                // copy file at destination
                screenshot.SaveAsFile(path + testName + ".png", ScreenshotImageFormat.Png);
            }
            //FrameworkHelper.WebDriver.Close();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            try
            {
                Reporter.Flush();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
