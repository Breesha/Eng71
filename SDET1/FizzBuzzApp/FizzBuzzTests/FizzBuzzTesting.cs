using NUnit.Framework;
using FizzBuzzExercise;

namespace FizzBuzzTests
{
    public class FizzBuzzShould
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void GiveOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(2,"2")]
        public void GiveAnyNumber_Return_OneString(int input, string expected)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenThree_Return_Fizz()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [TestCase(6,"Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input, string expected)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenFive_Return_Buzz()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GivenFifteen_Return_FizzBuzz()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(30)]
        [TestCase(45)]
        public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}