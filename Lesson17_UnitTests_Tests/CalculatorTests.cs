using System;
using Lesson17_UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson17_UnitTests_Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_ShouldReturnCorrectResult()
        {
            var result = Calculator.Sum(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult()
        {
            var result = Calculator.Subtract(1, 2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var result = Calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Pow2_ShouldReturnCorrectResult()
        {
            var result = Calculator.Pow2(3);
            Assert.AreEqual(9, result);
        }
    }
}
