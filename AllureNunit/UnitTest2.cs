namespace AllureNunit
{
    using Allure.Commons;
    using NUnit.Allure.Attributes;
    using NUnit.Allure.Core;
    using NUnit.Framework;
    using System;

    [AllureNUnit]
    [TestFixture]
    public class UnitTest2
    {

        [Test]
        [Category("Blabla")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite2")]
        [AllureSubSuite("Search module")]
        [AllureOwner("Siarhei Mahlysh")]
        [AllureSuite("Passed tests")]
        [AllureFeature("Document")]
        public void TestMethod2()
        {
            Console.WriteLine($"Results are saved into {AllureLifecycle.Instance.ResultsDirectory}");

            Console.WriteLine("hello allure");
            Assert.IsTrue(true);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("Skipped tests")]
        [AllureSubSuite("Search module")]
        [AllureOwner("Siarhei Mahlysh")]
        [AllureFeature("Document")]
        public void SkippedTest()
        {
            Console.WriteLine($"Results are saved into {AllureLifecycle.Instance.ResultsDirectory}");
            Assert.Ignore();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("Incoclusive tests")]
        [AllureSubSuite("Search module")]
        [AllureOwner("Siarhei Mahlysh")]
        [AllureFeature("Document")]
        public void IncoclusiveTest()
        {
            Console.WriteLine($"Results are saved into {AllureLifecycle.Instance.ResultsDirectory}");
            Assert.Inconclusive();
        }
    }  
}
