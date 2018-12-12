using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Prefab.tests
{
    [TestClass]
    public class CalculationServiceTests
    {
        [TestMethod, Description("should return the square of the user input")]
        public void CalculateSquare()
        {
            // Arrange
            var calculationService = new CalculationService();
            var input = 4;
            var expectedOutput = 16;

            // Act
            var output = calculationService.CalculateSquare(input);

            // Assert
            Assert.AreEqual(expectedOutput, output, $"The square of {input} should be {expectedOutput}!");
        }

        [TestMethod, Description("should throw an stackoverflow exception")]
        [ExpectedException(typeof(OverflowException))]
        public void ThrowsOverflowException()
        {
            // Arrange
            var calculationService = new CalculationService();
            var input = int.MaxValue;

            // Act
            var output = calculationService.CalculateSquare(input);
        }
    }
}
