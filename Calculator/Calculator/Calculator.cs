using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        // OVERLOADS
        public double Add(double a)
        {
            Accumulator = a + Accumulator;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator = a + Accumulator;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator = a * Accumulator;
            return Accumulator;
        }
        public double Divide(double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }
        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
        public double Accumulator { get; private set; }

    }
}