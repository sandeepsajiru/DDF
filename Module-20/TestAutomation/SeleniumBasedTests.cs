using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
    class SeleniumBasedTests : TestCaseBase
    {
        [Test]
        public void GoogleTest()
        {
            // Open Browser
            IWebDriver wd = new ChromeDriver();

            // Go to Google.com
            wd.Url = "http://google.com";

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
