using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnPositiveNumber()
        {
            var result = uut.Add(2, 5);
            Assert.That(result,Is.EqualTo(7));
        }

        [Test]
        public void Add_PositiveAndLowerNegativeNumber_ReturnPositiveNumber()
        {
            var result = uut.Add(5, -2);
            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        public void Add_PositiveAndHigherNegativeNumber_ReturnNegativeNumber()
        {
            var result = uut.Add(5, -7);
            Assert.That(result,Is.EqualTo(-2));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnNegativeNumber()
        {
            var result = uut.Add(-5, -7);
            Assert.That(result,Is.EqualTo(-12));
        }

        [Test]
        public void DivideTwoPositiveIntegers_ReturnPositiveNumber()
        {
            var result = uut.Divide(10, 5);
            Assert.That(result,Is.EqualTo(2));
        }
        [Test]
        public void DivideTwoPositiveDoubles_ReturnPositiveNumber()
        {
            var result = uut.Divide(10.5, 2.4);
            Assert.That(result, Is.EqualTo(4.375));
        }
        [Test]
        public void DividePositiveNumberWithNegativeNumber_ReturnNegativeNumber()
        {
            var result = uut.Divide(10, -1);
            Assert.That(result, Is.EqualTo(-10));
        }
        [Test]
        public void DivideNegativeNumberWithPositiveNumber_ReturnNegativeNumber()
        {
            var result = uut.Divide(-10, 1);
            Assert.That(result, Is.EqualTo(-10));
        }
        [Test]
        public void DivideTwoNegativeIntegers_ReturnPositiveNumber()
        {
            var result = uut.Divide(-10, -5);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DivideByZero_IsEqualToInfinity()
        {
            var result = uut.Divide(10, 0);
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void OverloadedAddPositiveIntegerAndAccumulator_ReturnsPositiveNumber()
        {
            uut.Add(5, 5);
            var result = uut.Add(4);
            Assert.That(result, Is.EqualTo(14));
        }
        [Test]
        public void OverloadedAddNegativeIntegerAndAccumulator_ReturnsCorrectNumber()
        {
            uut.Add(5, 5);
            var result = uut.Add(-4);
            Assert.That(result, Is.EqualTo(6));
        }
    }

}