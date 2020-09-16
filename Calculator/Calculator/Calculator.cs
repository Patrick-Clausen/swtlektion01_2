using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{

    class AccumulatorNotInitializedException : Exception
    {
        public AccumulatorNotInitializedException()
        {

        }

        public AccumulatorNotInitializedException(string exceptionString)
            : base(exceptionString)
        {

        }
    }
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            _accumulatorInitialized = true;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            _accumulatorInitialized = true;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            _accumulatorInitialized = true;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            _accumulatorInitialized = true;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
            _accumulatorInitialized = false;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                Accumulator = dividend / divisor;
                _accumulatorInitialized = true;
                return Accumulator;
            }
            else
            {
                throw new DivideByZeroException("Used Divide(dividend,divisor) with divisor==0!");
            }
            
        }

        // OVERLOADS
        public double Add(double a)
        {
            if (_accumulatorInitialized)
            {
                Accumulator = a + Accumulator;
                return Accumulator;
            }
            else
            {
                throw new AccumulatorNotInitializedException("Add(a) used with uninitialized Accumulator");
            }
            
        }

        public double Subtract(double a)
        {
            if (_accumulatorInitialized)
            {
                Accumulator = a + Accumulator;
                return Accumulator;
            }
            else
            {
                throw new AccumulatorNotInitializedException("Subtract(a) used with uninitialized Accumulator");
            }
            
        }

        public double Multiply(double a)
        {
            if (_accumulatorInitialized)
            {
                Accumulator = a * Accumulator;
                return Accumulator;
            }
            else
            {
                throw new AccumulatorNotInitializedException("Multiply(a) used with uninitialized Accumulator");
            }
            
        }
        public double Divide(double divisor)
        {
            if (divisor != 0)
            {
                if (_accumulatorInitialized)
                {
                    Accumulator = Accumulator / divisor;
                    return Accumulator;
                }
                else
                {
                    throw new AccumulatorNotInitializedException("Divide(divisor) used with uninitialized Accumulator");
                }
                
            }
            else
            {
                throw new DivideByZeroException("Used Divide(divisor) with divisor==0!");
            }
            
        }
        public double Power(double exp)
        {
            if (_accumulatorInitialized)
            {
                Accumulator = Math.Pow(Accumulator, exp);
                return Accumulator;
            }
            else
            {
                throw new AccumulatorNotInitializedException("Power(exp) used with uninitialized Accumulator");
            }
            
        }
        public double Accumulator { get; private set; }
        private bool _accumulatorInitialized = false;
    }
}