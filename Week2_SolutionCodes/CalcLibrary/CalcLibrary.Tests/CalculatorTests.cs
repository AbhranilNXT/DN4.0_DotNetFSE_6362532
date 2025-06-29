using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Teardown()
        {
            _calculator = null;
        }

        [Test]
        [TestCase(2.1, 3.7, 5.8)]
        [TestCase(-1.3, -1.0, -2.3)]
        [TestCase(0, 0, 0)]
        public void Addition_AddsTwoNumbers_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }
    }
}