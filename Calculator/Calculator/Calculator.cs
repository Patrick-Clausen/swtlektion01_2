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
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        // OVERLOADS
        public double Add(double a)
        {
            Accumulator = a + Accumulator;
            return a + Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator = a + Accumulator;
            return a - Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator = a * Accumulator;
            return a * Accumulator;
        }
        public double Divide(double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator / divisor;
        }
        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Math.Pow(Accumulator, exp);
        }

    }
}