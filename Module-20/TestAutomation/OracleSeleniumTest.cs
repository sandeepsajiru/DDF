using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomation
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    class OracleSeleniumTest : TestCaseBase
    {

        [Test, TestCaseSource(typeof(TestCaseBase), "BrowserData")]
        public void OracleTest(String browserName)
        {
            RunTest(browserName, "http://oracle.com");
        }
    }
}
