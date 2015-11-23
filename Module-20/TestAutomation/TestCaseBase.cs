using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrivenFramework;
using NUnit.Framework;
using log4net;
using log4net.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

[assembly: LevelOfParallelism(4)]

[SetUpFixture]
public class TestSuiteSetup
{
    //http://nunit.org/index.php?p=setupFixture&r=2.6.3
    // Only one SetUpFixture should be created in a given namespace. A SetUpFixture outside of any namespace provides SetUp and TearDown for the entire assembly.
    
    [OneTimeSetUp]
    public void InitLogger()
    {
        XmlConfigurator.Configure();
    }
}

namespace TestAutomation
{
    public class TestCaseBase
    {
        protected ILog APP_LOGGER = LogManager.GetLogger("AppLogger");

        protected void ValidateRunMode(String suiteName, String testName, String runMode)
        {
            APP_LOGGER.Debug("Validating RunMode");
            bool isSuiteSelected = SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath,
                suiteName);
            bool isTestSelected = SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath,
                testName);
            bool isDataSelected = runMode.Equals("Y", StringComparison.OrdinalIgnoreCase) ? true : false;

            if (!(isSuiteSelected && isTestSelected && isDataSelected))
                Assert.Ignore(String.Format("Skipping Test - SuiteRunMode: {0}, TestRunMode: {1}, DataRunMode: {2}",
                    isSuiteSelected, isTestSelected, isDataSelected));
        }

        protected void RunTest(String browserType, String url)
        {
            APP_LOGGER.Debug("Running Test With " + browserType + " on URL " + url);

            // Open Browser
            IWebDriver wd ;

            if (browserType.Equals("firefox"))
                wd = new RemoteWebDriver(new Uri(ResourceTestFilePaths.GridHubURL), DesiredCapabilities.Firefox());
            else if (browserType.Equals("safari"))
                wd = new RemoteWebDriver(new Uri(ResourceTestFilePaths.GridHubURL), DesiredCapabilities.Safari());
            else if(browserType.Equals("chrome"))
                wd = new RemoteWebDriver(new Uri(ResourceTestFilePaths.GridHubURL), DesiredCapabilities.Chrome());
            else
                wd = new RemoteWebDriver(new Uri(ResourceTestFilePaths.GridHubURL), DesiredCapabilities.InternetExplorer());

            // Go to Google.com
            wd.Url = url;

            Random rnd = new Random();
            int randomSeconds = rnd.Next(1, 11);
            
            // Wait for Random Time (1s to 10 s)
            APP_LOGGER.DebugFormat("Waiting for {0} seconds Before Exiting Browser", randomSeconds);
            Thread.Sleep(TimeSpan.FromSeconds(randomSeconds));

            // Quit Browser
            wd.Quit();
        }


        // DATA SOURCE
        public static IEnumerable<String> BrowserData()
        {
            String[] browsers = ResourceTestFilePaths.BrowserToRunWith.Split(new char[] { ',' });

            foreach (var b in browsers)
            {
                yield return b;
            }

        }
    }
}
