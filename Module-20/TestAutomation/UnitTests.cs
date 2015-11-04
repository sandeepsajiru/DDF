using System;
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
            Console.WriteLine(SelectionHelper.IsSuiteSelected("TestData\\Suite.xlsx", "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("TestData\\Suite.xlsx", "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("TestData\\Suite.xlsx", "SuiteC"));
        }

        [Test]
        public void TestSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsTestSelected("TestData\\SuiteA.xlsx", "Test1"));
            Console.WriteLine(SelectionHelper.IsTestSelected("TestData\\SuiteA.xlsx", "Test2"));
            Console.WriteLine(SelectionHelper.IsTestSelected("TestData\\SuiteA.xlsx", "Test3"));
        }
    }
}