using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,8,9)]
        public void AddTest(int num1, int num2, int expected)
        {
            var result = CalculatorMethod.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }
    }
}