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
        [Test]
        public void OracleTest()
        {
            RunTest("firefox", "http://oracle.com");   
        }

    }
}
