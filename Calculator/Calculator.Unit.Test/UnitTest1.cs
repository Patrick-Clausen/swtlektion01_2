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

        #region Add Method
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
        #endregion

        #region Subtract Method
        [TestCase(12, 5, 7)]
        [TestCase(-5, 7, -12)]
        [TestCase(-12, -7, -5)]
        public void Subtract_PositiveAndNegativeNumbers_ReturnIsCorrect(int a, int b, int c)
        {
            var result = uut.Subtract(a, b);
            Assert.That(result, Is.EqualTo(c));
        }

        [TestCase(12, 5, 7)]
        [TestCase(-5, 7, -12)]
        [TestCase(-12, -7, -5)]
        public void Subtract_PositiveAndNegativeNumbers_AccumulatorIsCorrect(int a, int b, int c)
        {
            uut.Subtract(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }
        #endregion

        #region Divide Method
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
        #endregion

        #region Multiply Method
        [TestCase(5,10,50)]
        [TestCase(2,8,16)]
        [TestCase(0,1,0)]
        [TestCase(0,0,0)]
        [TestCase(1,-6,-6)]
        [TestCase(-5,-7,35)]
        public void Multiply_PositiveAndNegativeNumbers_ResultIsCorrect(int a, int b, int c)
        {
            var result = uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(c));
        }

        [TestCase(5, 10, 50)]
        [TestCase(2, 8, 16)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(1, -6, -6)]
        [TestCase(-5, -7, 35)]
        public void Multiply_PositiveAndNegativeNumbers_AccumulatorIsCorrect(int a, int b, int c)
        {
            uut.Multiply(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }
        #endregion

        #region Power Method
        /*
        public void Power_x_y(double x, double exp)
        {
            var result = uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(c));
        }

        public void Power_x_y(double x, double exp)
        {
            var result = uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(c));
        }

        public void Power_x_y(double x, double exp)
        {
            var result = uut.Multiply(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
        */
        #endregion

        #region Overloaded Add Method
        [TestCase(4, 2, 2, 8)]
        [TestCase(-6, 4, 4, 2)]
        [TestCase(5, -5, -5, -5)]
        [TestCase(1.2, 4.2, -2.1, 3.3)]
        public void OverloadedAddDoubleAndAccumulator_ReturnsCorrectNumber(double a, double acc_1, double acc_2, double b)
        {
            uut.Add(acc_1, acc_2);
            var result = uut.Add(a);
            Assert.That(result, Is.EqualTo(b));
        }
        #endregion

        #region Overloaded Subtract Method
        [TestCase(12, 20, 4,4 )]
        [TestCase(6, 10, 12, -8)]
        [TestCase(-2, 2, 7, -3)]
        [TestCase(4.2, 6.6, 3.7, -1.3000000000000007)]
        public void OverloadedSubtractDoubleAndAccumulator_ReturnsCorrectNumber(double a, double acc_1, double acc_2, double b)
        {
            uut.Subtract(acc_1, acc_2);
            var result = uut.Subtract(a);
            Assert.That(result, Is.EqualTo(b));
        }

        #endregion

        #region Overloaded Divide Method

        #endregion

        #region Overloaded Multiply

        #endregion

        #region Overloaded Power Method

        #endregion

        #region Accumulator
        [Test]
        public void Add_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Add(2, 5);
            Assert.That(uut.Accumulator, Is.EqualTo(7));
        }

        [Test]
        public void Add_TwoNegativeNumbers_AccumulatorIsCorrect()
        {
            uut.Add(-2, -7);
            Assert.That(uut.Accumulator, Is.EqualTo(-9));
        }
        #endregion

        #region Clear

        #endregion 
    }
}