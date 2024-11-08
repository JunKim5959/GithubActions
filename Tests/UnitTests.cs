using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void PowerTestKim()
        {
            double result = Program.Power("2", "3");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SubtractTestKim()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-1, Program.Subtract("2", "3"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }
         [Test]
        public void MultyplyTestKim()
        {
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(0, Program.Multiply("2", "0"));
            Assert.AreEqual(-15, Program.Multiply("-3", "5"));
        }
         [Test]
        public void DivideTestKim()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
        }
        // Implement 3 tests per operation, following a similar pattern as above
    }
}
