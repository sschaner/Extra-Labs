using System;
using System.Collections.Generic;
using System.Text;
using Lab5FactorialCalculator;
using Xunit;

namespace Lab5FactorialCalculator.Tests
{
    public class ValidateIntInputTests
    {
        [Fact]
        public void UserGivesValidInput_ReturnsTrue()
        {
            // Arrange
            HelperMethods subject = new HelperMethods();
            string userInput = new string("4");

            // Act
            bool returnValue = subject.ValidateIntInput(userInput);

            // Assert
            Assert.True(returnValue);
        }

        [Fact]
        public void UserGivesInvalidInput_ReturnsFalse()
        {
            // Arrange
            HelperMethods subject = new HelperMethods();
            string userInput = new string("a");

            // Act
            bool returnValue = subject.ValidateIntInput(userInput);

            // Assert
            Assert.False(returnValue);
        }
    }
}
