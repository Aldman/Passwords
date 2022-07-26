using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Passwords
{
    [TestFixture]
    class CaseAlternatorTest
    {
        private static IEnumerable<TestCaseData> CaseAlternatorCaseData
        {
            get
            {
                string initPassword = "ab42";
                var expectedResult = new List<string>()
                {
                    "ab42",
                    "aB42",
                    "Ab42",
                    "AB42"
                };
                yield return new TestCaseData(initPassword, expectedResult)
                    .SetName("Password from instance");
            }
        }

        [TestCaseSource("CaseAlternatorCaseData")]
        public void AlternateCharCasesTests
            (string initPassword, List<string> expectedResult)
        {
            var actualResult = CaseAlternatorTask
                .AlternateCharCases(initPassword);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
