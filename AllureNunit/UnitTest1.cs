
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
 
        [Test(Description = "Hello allure")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestMethod1()
        {
            Console.WriteLine($"Results are saved into {AllureLifecycle.Instance.ResultsDirectory}");
         
            Console.WriteLine("hello allure");
            Assert.IsTrue(true);
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public void EvenTest([Range(0, 5)] int value)
        {
            Assert.IsTrue(value % 2 == 0, $"Oh no :( {value} % 2 = {value % 2}");
        }

    }
}
