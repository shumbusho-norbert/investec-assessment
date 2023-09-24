using Investec.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Investec.AppUnitTest
{
    [TestClass]
    public class TextProcessorFactoryTests
    {
        public static IEnumerable<object[]> ValidTypes()
        {
            var validTypes = new List<object[]>
            {
                new object[] { "1", typeof(TextDuplicateChecker) },
                new object[] { "2", typeof(VowelCounter) },
                new object[] { "3", typeof(VowelAndNoVowelCounter) }
            };

            return validTypes;
        }

        [DataTestMethod]
        [DynamicData(nameof(ValidTypes), DynamicDataSourceType.Method)]
        public void CreateTextProcessor_ValidInput_ReturnsCorrectType(string input, Type expectedType)
        {
            // Arrange
            var factory = new TextProcessorFactory();

            // Act
            ITextProcessor processor = factory.CreateTextProcessor(input);

            // Assert
            Assert.IsInstanceOfType(processor, expectedType);
        }
        [DataTestMethod]
        [DataRow("invalid")]
        [DataRow("6")]
        [DataRow("")]
        public void CreateTextProcessor_InvalidInput_ThrowsArgumentException(string input)
        {
            // Arrange
            var factory = new TextProcessorFactory();

            // Act and Assert, throw an exception on all input not in 1,2,3 or a combination thereof
            Assert.ThrowsException<ArgumentException>(() => factory.CreateTextProcessor(input));
        }
    }
}
