using Investec.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Investec.AppUnitTest
{
    [TestClass]
    public class VowelAndNoVowelCounterTests
    {
        public static IEnumerable<object[]> SampleTestData()
        {
            yield return new object[] { "I eat", "The text has more vowels than nonvowels" };
            yield return new object[] { "that dog", "The text has more non vowels than vowels" };
            yield return new object[] { "3 a", "The text has an equal amount of vowels and non vowels." };
        }

        [DataTestMethod]
        [DynamicData(nameof(SampleTestData), DynamicDataSourceType.Method)]
        public void ProcessText_TestCases(string input, string expectedResult)
        {
            // Arrange
            var counter = new VowelAndNoVowelCounter();

            // Act
            string result = counter.ProcessText(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
