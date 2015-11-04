using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatadrivenFramework;

namespace DataDrivenFramework
{
    public class SelectionHelper
    {
        public static bool IsTestSelected(String suiteFilePath, String testName)
        {
            ExcelHelper eh = new ExcelHelper(suiteFilePath);
            int testCaseRowNumber = eh.GetRowNumber("TestCases", "TestCases", testName);
            String runModeValue = eh.GetCellData("TestCases", "Runmode", testCaseRowNumber);

            // APPROACH 2
            return runModeValue.Equals("Y", StringComparison.OrdinalIgnoreCase);

        }
        public static bool IsSuiteSelected(String suitesFilePath, String suiteName)
        {
            ExcelHelper eh  = new ExcelHelper(suitesFilePath);
            int suiteRowNumber = eh.GetRowNumber("Suite", "SuiteName", suiteName);
            String runModeValue = eh.GetCellData("Suite", "Runmode", suiteRowNumber);

            // APPROACH 1
            if (runModeValue.Equals("Y", StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}
