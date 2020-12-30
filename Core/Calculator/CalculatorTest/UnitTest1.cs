using NUnit.Framework;
using Calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 8, 9)]
        [TestCase(12,3,15)]
        [TestCase(10, 5, 15)]
        public void AddTest(double num1, double num2, double expected)
        {
            var result = CalculatorMethod.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(9, 4, 5)]
        [TestCase(20, 7, 13)]
        [TestCase(5, 2, 3)]
        public void SubtractTest(double num1, double num2, double expected)
        {
            var result = CalculatorMethod.Subtract(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 8, 16)]
        [TestCase(5, 10, 50)]
        [TestCase(6, 7, 42)]
        public void MultiplyTest(double num1, double num2, double expected)
        {
            var result = CalculatorMethod.Multiply(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(30, 10, 3)]
        [TestCase(56, 8, 7)]
        [TestCase(100, 10, 10)]
        public void DivideTest(double num1, double num2, double expected)
        {
            var result = CalculatorMethod.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1,0)]
        public void DivideByZeroExceptionTest(double a, double b)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => CalculatorMethod.Divide(a, b));
            Assert.AreEqual("Cannot divide by zero", ex.Message);
        }

        [TestCase(12, 5, 2)]
        [TestCase(20, 7, 6)]
        [TestCase(50, 40, 10)]
        public void ModulusTest(double num1, double num2, double expected)
        {
            var result = CalculatorMethod.Modulus(num1, num2);
            Assert.AreEqual(expected, result);
        }
    }
}