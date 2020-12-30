using NUnit.Framework;

namespace SafariPark
{
    public class PersonTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase("Nish", "Mandal", "Nish Mandal")]
        [TestCase("",""," ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }

        public void AgeTest()
        {
            var subject = new Person("Nish", "Mandal");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
}