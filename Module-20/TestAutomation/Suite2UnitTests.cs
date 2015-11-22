using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrivenFramework;
using NUnit.Framework;

namespace TestAutomation
{

    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    class Suite2UnitTests : TestCaseBase
    {
        [Test, TestCaseSource("Test4Data")]
        public void DataDrivenTest4(Dictionary<String, String> dict)
        {
            ValidateRunMode("SuiteB", "Test4", dict["Runmode"]);
            APP_LOGGER.DebugFormat("RunMode: {0}, Col1: {1}", dict["Runmode"], dict["Col1"]);

        }

        // DATA SOURCE
        public static IEnumerable<Dictionary<String, String>> Test4Data()
        {
            List<Dictionary<String, String>> tdList = SelectionHelper.GetTestData(
                ResourceTestFilePaths.SuiteAExcelFilePath, "Test4");

            foreach (var dict in tdList)
            {
                yield return dict;
            }

        }
    }
}
