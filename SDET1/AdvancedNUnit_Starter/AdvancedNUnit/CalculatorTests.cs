using NUnit.Framework;

namespace AdvancedNUnit
{
    //[Ignore("Not using these tests yet")]

    public class Tests
    {
        
        public void Setup() { }

        [Category("Happy Path")]
        [Test]
        public void Add_Always_ReturnsExpectedResult_ClassicModel()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.AreEqual(6, result);

            ////Other Asserts using the Classic Model
            ///Assert.True, Assert.Flase, Assert.Null
        }

        [Category("Error Path")]
        [Test]
        public void Add_Always_ReturnsExpectedResult_ConstraintModel()
        {
            //Arrange
            var subject = new Calculator();

            //Act & Assert
            Assert.That(subject.Add(2, 4), Is.EqualTo(6));
            Assert.That(subject.DivisibleBy3(6));
            Assert.That(subject.DivisibleBy3(7), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Nish"));

        }

        //Testing Exceptions
        [Category("Happy Path")]
        [Test]
        public void DivideByZeroExceptionTest()
        {
            //Arrange
            var subject = new Calculator();

            //Act & Assert
            Assert.That(()=>subject.Divide(5,0), Throws.ArgumentException);
            Assert.That(() => subject.Divide(5, 0), Throws.ArgumentException.With.Message.EqualTo("Can't divide by 0"));
        }


        //String Constraints
        [Category("Happy Path")]
        [Test]
        public void StringConstranitTests()
        {
            var subject = new Calculator();
            var strResult = subject.ToString();
            Assert.That(strResult, Does.Contain("Calculator"));
            Assert.That(strResult, Does.Not.Contain("Potato"));
            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Is.EqualTo("advancedNUnit.Calculator").IgnoreCase);
            Assert.That(strResult, Is.Not.Empty);
            Assert.That(strResult, Has.Length.GreaterThan(10));
        }

        [Category("Happy Path")]
        [TestCaseSource("AddCases")]
        public void Add_Always_ReturnExpectedResukt(int x, int y, int expected)
        {
            var subject = new Calculator();
            Assert.That(subject.Add(x, y), Is.EqualTo(expected));
        }

        public static object[] AddCases =
        {
            new int[] {2,4,6},
            new int[] {-2,3,1}
        };

    }
}