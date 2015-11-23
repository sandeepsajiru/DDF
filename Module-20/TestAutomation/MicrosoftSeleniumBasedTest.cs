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
        [Test, TestCaseSource(typeof(TestCaseBase), "BrowserData")]
        public void MicrosoftTest(String browser)
        {
            RunTest(browser, "http://microsoft.com");
        }

    }
}
