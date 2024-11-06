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
        public void Subtract_ValidTroia()
        {
            Assert.AreEqual(3, Program.Subtract("5", "3"));
            Assert.AreEqual(0, Program.Subtract("8", "8"));
            Assert.AreEqual(2, Program.Subtract("9", "7"));
        }

        [Test]
        public void Subtract_InvalidTroia()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullTroia()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_ValidTroia()
        {
            Assert.AreEqual(12, Program.Multiply("3", "4"));
            Assert.AreEqual(25, Program.Multiply("5", "5"));
            Assert.AreEqual(3, Program.Multiply("3", "1"));
        }

        [Test]
        public void Multiply_InvalidTroia()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("5", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "5"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullTroia()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_ValidTroia()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(4, Program.Divide("16", "4"));
            Assert.AreEqual(2, Program.Divide("32", "16"));
        }

        [Test]
        public void Divide_InvalidTroia()
        {
            Assert.Throws<FormatException>(() => Program.Divide("5", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "5"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullTroia()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_ValidTroia()
        {
            Assert.AreEqual(16, Program.Power("2", "4"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(1, Program.Power("1", "5"));
        }

        [Test]
        public void Power_InvalidTroia()
        {
            Assert.Throws<FormatException>(() => Program.Power("5", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "5"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullTroia()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
