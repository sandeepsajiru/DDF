using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrivenFramework;
using NUnit.Framework;

namespace TestAutomation
{
    public class TestCaseBase
    {
        protected void ValidateRunMode(String suiteName, String testName, String runMode)
        {
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
