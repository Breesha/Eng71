using NUnit.Framework;
using Lab_11_Exceptions;
using System;

namespace Lab_11_Exceptions_TEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
        [TestCase(4)]
        public void WhenAnIllegalPositionIsSpecifiedANExceptionIsThrown(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => Program.ChangeBeatles(pos, "George"));
            Assert.AreEqual($"Another Beatle cannot be added", ex.Message, "Exception message not correct");
        }
    }
}