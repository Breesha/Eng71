using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedNUnit
{
    //[Ignore("Not using these tests yet")]

    class ConstraintExampleTests
    {
        
        //Constraint vs Class
        [Category("Error Path")]
        [Test]
        public void ClassicAssertionModel()
        {
            List<int> myList = new List<int> { 1, 2, 3 };
            Assert.AreEqual(1, myList.Where(x => x == 4).Count());
        }

        [Category("Error Path")]
        [Test]
        public void ConstraintAssertionModel()
        {
            List<int> myList = new List<int> { 1, 2, 3 };
            Assert.That(1, Has.Exactly(1).EqualTo(4));
        }


        //Collection Constraints
        [Category("Happy Path")]
        [Test]
        public void TestListOfStrings()
        {
            var fruit = new List<string> { "apple", "pear", "peach" };
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
            Assert.That(fruit, Has.Exactly(2).With.Length.EqualTo(5));
            Assert.That(fruit, Does.Contain("pea"));
            Assert.That(fruit, Has.Count.EqualTo(4));
        }


        //Range Constraints
        [Category("Happy Path")]
        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1, 10));

            var nums = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(1, 5));
        }
    }
}
