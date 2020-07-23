using NUnit.Framework;

namespace Sample.testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            var calculate = new Calculate();
            var actual = calculate.Add(4, 2);
            Assert.AreEqual(6,actual);
        }
        [Test]
        public void TestSubtract()
        {
            var calculate = new Calculate();
            var actual = calculate.Subtract(4, 2);
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void TestDivison()
        {
            var calculate = new Calculate();
            var actual = calculate.Divison(4, 2);
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void TestMultiplication()
        {
            var calculate = new Calculate();
            var actual = calculate.Multiplication(4, 2);
            Assert.AreEqual(8, actual);
        }
    }
}