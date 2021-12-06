using System;
using System.Collections.Generic;
using System.Text;
using Lab5FactorialCalculator;
using Xunit;

namespace Lab5FactorialCalculator.Tests
{
    public class FactorialWithForLoopTests
    {
        [Fact]
        public void UserGivesValidInput_ReturnsTrue()
        {
            // Arrange
            HelperMethods subject = new HelperMethods();
            int userChosenInteger = 4;

            // Act
            long returnValue = subject.FactorialWithForLoop(userChosenInteger);

            // Assert
            Assert.Equal(24, returnValue);
        }
    }
}
