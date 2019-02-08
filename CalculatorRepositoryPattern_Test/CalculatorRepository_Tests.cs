using System;
using Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorRepositoryPattern_Test
{
    [TestClass]
    public class CalculatorRepository_Tests
    {
        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectInt()
        {
            // Arrange
            CalculatorRepository calculatorRepo = new CalculatorRepository();

            // Act
            int actual = calculatorRepo.AddTwoNumbers(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubtractTwoNumbers_ShouldBeCorrectInt()
        {
            // Arrange
            CalculatorRepository calculatorRepo = new CalculatorRepository();

            // Act
            int actual = calculatorRepo.SubtractTwoNumbers(2, 2);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectInt()
        {
            // Arrange
            CalculatorRepository calculatorRepo = new CalculatorRepository();

            // Act
            int actual = calculatorRepo.MultiplyTwoNumbers(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectInt()
        {
            // Arrange
            CalculatorRepository calculatorRepo = new CalculatorRepository();

            // Act
            int actual = calculatorRepo.DivideTwoNumbers(2, 2);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CalculatorRepository_RemainderTwoNumbers_ShouldReturnCorrectInt()
        {
            // Arrange
            CalculatorRepository calculatorRepo = new CalculatorRepository();

            // Act
            int actual = calculatorRepo.RemainderOperator(2, 2);

            // Assert
            Assert.AreEqual(0, actual);
            Dogs 
        }
    }
}
