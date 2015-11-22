using System;
using System.Collections.Generic;
using NUnit.Framework;
using DataDrivenFramework;

namespace TestAutomation
{
    [TestFixture]
    public class Suite1UnitTests : TestCaseBase
    {
        [Test]
        public void SuiteSelectionTest()
        {
            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteA"));
            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteB"));
            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteC"));
        }

        [Test]
        public void TestSelectionTest()
        {
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test1"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test2"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test3"));
        }

        [Test]
        public void TestDataReadingTest()
        {
            List<Dictionary<String, String>> tdList = SelectionHelper.GetTestData(ResourceTestFilePaths.SuiteAExcelFilePath, "Test4");

            foreach (var dict in tdList)
            {
                APP_LOGGER.DebugFormat("RunMode: {0}, Col1: {1}", dict["Runmode"], dict["Col1"]);
            }

        }

       

        [Test, TestCaseSource("Test1Data")]
        public void DataDrivenTest1(Dictionary<String, String> dict)
        {
            ValidateRunMode("SuiteA", "Test1", dict["Runmode"]);
            APP_LOGGER.DebugFormat("RunMode: {0}, Col1: {1}", dict["Runmode"], dict["Col1"]);

        }


        // DATA SOURCE
        IEnumerable<Dictionary<String, String>> Test1Data()
        {
            List<Dictionary<String, String>> tdList = SelectionHelper.GetTestData(
                ResourceTestFilePaths.SuiteAExcelFilePath, "Test1");

            foreach (var dict  in tdList)
            {
                yield return dict;
            }

        }
    }
}