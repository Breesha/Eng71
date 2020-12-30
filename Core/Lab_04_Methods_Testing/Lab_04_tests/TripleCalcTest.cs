using NUnit.Framework;
using Lab_04_Methods_Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab_04_tests
{
    public class TripleCalcTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10,2,3,60)]
        [TestCase(0,-3,7, 0)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            // Arrange and act
            //var result = Lab_04_Methods_Testing.Program.TripleCalc(10, 2, 3, out int sum);
            // Assert
            var actual = Lab_04_Methods_Testing.Program.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 4, 16)]
        [TestCase(0, -3, 7, 4)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Lab_04_Methods_Testing.Program.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, sum);
        }
    }
}