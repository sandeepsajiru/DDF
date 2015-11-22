using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrivenFramework;
using NUnit.Framework;
using log4net;
using log4net.Config;



[SetUpFixture]
public class TestSuiteSetup
{
    //http://nunit.org/index.php?p=setupFixture&r=2.6.3
    // Only one SetUpFixture should be created in a given namespace. A SetUpFixture outside of any namespace provides SetUp and TearDown for the entire assembly.
    
    [SetUp]
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
    }
}
