using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class CalculatorTests
    {

        [TestCase(1, 3, ExpectedResult = 3),
         TestCase(1.02, 0, ExpectedResult = 0)]
        public double Calculate_CorrectDataForMultiply(double operator1, double operator2)
        {
            //Arrange
            //Act
            return Calculator.Calculate(operator1, operator2, OperationType.Multiply);
        }

        [TestCase(1, 3, ExpectedResult = -2),
        TestCase(1.02, 0, ExpectedResult = 1.02)]
        public double Calculate_CorrectDataForDeduction(double operator1, double operator2)
        {
            //Arrange
            //Act
            return Calculator.Calculate(operator1, operator2, OperationType.Minus);
        }

        [Test]
        public void Calculate_WhenOperationIsNotExistItShouldThrowException()
        {
            //Arrange
            //Act
            var exception = Assert.Throws<NotImplementedException>(() => Calculator.Calculate(3, 0, 0));

            //Assert
            Assert.AreEqual("Unknown operation", exception.Message);
        }

        [Test]
        public void Calculate_WhenDivideByZeroItShouldThrowException()
        {
            //Arrange
            //Act
            var exception = Assert.Throws<DivideByZeroException>(() => Calculator.Calculate(3, 0, OperationType.Divide));

            //Assert
            Assert.AreEqual("You try to divide by 0", exception.Message);
        }
    }
}
