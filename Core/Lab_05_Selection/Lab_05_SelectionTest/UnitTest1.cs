//using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab_05_Selection;
using NUnit.Framework;

namespace Lab_05_SelectionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Mark40AndOverPasses()
        //{
        //    var result = Program.PassFail(40);
        //    Assert.AreEqual("Pass", result);
        //}

        //[Test]
        //public void Mark39AndUnderFails()
        //{
        //    var result = Program.PassFail(39);
        //    Assert.AreEqual("Fail", result);
        //}

        //[TestCase(80)]
        //[TestCase(90)]
        //public void Mark75AndOverPassesWithDistinction(int mark)
        //{
        //    var result = Program.Grade(mark);
        //    Assert.AreEqual("Pass with distinction", result);
        //}

        //[TestCase(62)]
        //[TestCase(70)]
        //public void MarkBetween60And74PassesWithMerit(int mark)
        //{
        //    var result = Program.Grade(mark);
        //    Assert.AreEqual("Pass with merit", result);
        //}

        [TestCase(5, "Error")]
        [TestCase(3, "Code Red")]
        [TestCase(2, "Code Amber")]
        [TestCase(1, "Code Amber")]
        [TestCase(0, "Code Green")]
        public void PriorityTest(int level, string expected)
        {
            Assert.AreEqual(expected, Program.Priority(level));
        }
    }
}