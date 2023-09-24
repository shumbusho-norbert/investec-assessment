using Investec.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec.AppUnitTest
{
    [TestClass]
    public class TextDuplicateCheckerTests
    {
        [DataTestMethod]
        [DataRow("I like eating apples", "Found the following duplicates: ileap")]
        [DataRow("abcd4", "No duplicate found.")]
        public void ProcessText_TestCases(string input, string expectedResult)
        {
            // Arrange
            var duplicateChecker = new TextDuplicateChecker();

            // Act
            string result = duplicateChecker.ProcessText(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
