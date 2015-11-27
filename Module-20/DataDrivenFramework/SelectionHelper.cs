using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatadrivenFramework;
using System.Reflection;
using System.IO;

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

        public static List<Dictionary<String, String>> GetTestData(String suiteFilePath, String testCaseName)
        {
            List<Dictionary<String, String>> listOfData = new List<Dictionary<string, string>>();

            String pathOfExecutingAssmebly = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            ExcelHelper eh = new ExcelHelper(Path.Combine(pathOfExecutingAssmebly, suiteFilePath));

            // Find Row Number for testCaseName - by searching it in first Column
            int testRowNumber = eh.GetRowNumber("Data", 1, testCaseName);

            int colHeadersRowNumber = testRowNumber + 1;

            int testDataRowId = colHeadersRowNumber + 1;
            int endRowId = testDataRowId;
            while (!eh.GetCellData("Data", 1, endRowId).Equals(""))
                endRowId++;

            for (int i = testDataRowId; i < endRowId; i++)
            {
                Dictionary<String, String> data = new Dictionary<string, string>();
                int colId = 1;
                while (!eh.GetCellData("Data", colId, colHeadersRowNumber).Equals(""))
                {
                    data.Add(eh.GetCellData("Data", colId, colHeadersRowNumber), eh.GetCellData("Data", colId, i));
                    colId++;
                }

                listOfData.Add(data);
            }

            return listOfData;
        } 
    }
}
