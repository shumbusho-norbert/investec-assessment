using Investec.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Investec.AppUnitTest
{
    [TestClass]
    public class VowelCounterTests
    {
        [DataTestMethod]
        [DataRow("I like eating apples", "The number of vowels is:8")]
        [DataRow("", "No vowels found.")]
        public void ProcessText_ValidInput_ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange
            var vowelCounter = new VowelCounter();

            // Act
            string result = vowelCounter.ProcessText(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
