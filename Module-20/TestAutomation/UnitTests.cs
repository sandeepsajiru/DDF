using System;
using System.Collections.Generic;
using NUnit.Framework;
using DataDrivenFramework;

namespace TestAutomation
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void SuiteSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(ResourceTestFilePaths.SuitesExcelFilePath, "SuiteC"));
        }

        [Test]
        public void TestSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test1"));
            Console.WriteLine(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test2"));
            Console.WriteLine(SelectionHelper.IsTestSelected(ResourceTestFilePaths.SuiteAExcelFilePath, "Test3"));
        }

        [Test]
        public void TestDataReadingTest()
        {
            List<Dictionary<String, String>> tdList = SelectionHelper.GetTestData(ResourceTestFilePaths.SuiteAExcelFilePath, "Test4");

            foreach (var dict in tdList)
            {
                Console.WriteLine("RunMode: {0}, Col1: {1}", dict["Runmode"], dict["Col1"]);
            }

        }
    }
}