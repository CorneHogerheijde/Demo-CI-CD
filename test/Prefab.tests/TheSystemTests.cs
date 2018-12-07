using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prefab.tests
{
    [TestClass]
    public class TheSystemTests
    {
        [TestMethod, Description("should output the square of the user input")]
        public void ShouldOutputSquare()
        {
            // Arrange
            var mockSquareCalculator = new Mock<ICalculationService>();
            mockSquareCalculator.Setup(c => c.GetSquare(It.IsAny<int>())).Returns(16);
            var system = new TheSystem(mockSquareCalculator.Object);

            // Act
            var output = system.ProcessUserInput("4");

            // Assert
            Assert.AreEqual("The square of 4 is 16", output);
        }

        [TestMethod, Description("should output an error message when a string which does not represent a number is inputted")]
        public void ShouldOutputErrorMessage()
        {
            // Arrange
            var mockSquareCalculator = new Mock<ICalculationService>();
            mockSquareCalculator.Setup(c => c.GetSquare(It.IsAny<int>())).Returns(16);
            var system = new TheSystem(mockSquareCalculator.Object);

            // Act
            var output = system.ProcessUserInput("Please calculate the square of 4.");

            // Assert
            Assert.AreEqual("You're dead. That was not the requested number.", output);
        }

    }
}
