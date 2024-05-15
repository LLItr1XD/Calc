using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            Calc1 calculator = new Calc1();

            double result = calculator.Add(5, 3);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_WhenCalled_ReturnsCorrectDifference()
        {
            Calc1 calculator = new Calc1();

            double result = calculator.Subtract(5, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_WhenCalled_ReturnsCorrectProduct()
        {
            // Arrange
            Calc1 calculator = new Calc1();

            // Act
            double result = calculator.Multiply(5, 3);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_WhenCalledWithNonZeroDivisor_ReturnsCorrectQuotient()
        {
            Calc1 calculator = new Calc1();

            double result = calculator.Divide(6, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Divide_WhenCalledWithZeroDivisor_ThrowsDivideByZeroException()
        {
            Calc1 calculator = new Calc1();

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(5, 0));
        }
    }
}
