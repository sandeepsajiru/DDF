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
        [Test, TestCaseSource(typeof(TestCaseBase), "BrowserData")]
        public void GoogleTest(String browserName)
        {
            RunTest(browserName, "http://google.com");
        }

    }
}
