using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomation
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    class MicrosoftSeleniumTest : TestCaseBase
    {
        [Test]
        public void MicrosoftTest()
        {
            // Open Browser
            IWebDriver wd = new InternetExplorerDriver();

            // Go to Google.com
            wd.Url = "http://microsoft.com";

            Random rnd = new Random();
            int randomSeconds = rnd.Next(1, 11);
            
            // Wait for Random Time (1s to 10 s)
            APP_LOGGER.DebugFormat("Waiting for {0} seconds Before Exiting Browser", randomSeconds);
            Thread.Sleep(TimeSpan.FromSeconds(randomSeconds));

            // Quit Browser
            wd.Quit();
        }

    }
}
