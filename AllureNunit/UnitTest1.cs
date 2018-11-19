
namespace AllureNunit
{
    using System;

    using Allure.Commons;

    using NUnit.Allure.Attributes;
    using NUnit.Allure.Core;
    using NUnit.Framework;

    [AllureNUnit]
    [TestFixture]
    public class UnitTest1
    {
 
        [Test]
        [AllureFeature("Core")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("Passed tests")]
        [AllureSubSuite("Search module")]
        [AllureOwner("Siarhei Mahlysh")]
        public void TestMethod1()
        {
            Console.WriteLine($"Results are saved into {AllureLifecycle.Instance.ResultsDirectory}");
         
            Console.WriteLine("hello allure");
            Assert.IsTrue(true);
        }

        [Test]
        [AllureFeature("Core")]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureOwner("Siarhei Mahlysh")]
        [AllureSuite("PartiallyFailedSuite")]
        public void EvenTest([Range(0, 5)] int value)
        {
            Assert.IsTrue(value % 2 == 0, $"Oh no :( {value} % 2 = {value % 2}");
        }

    }
}
