using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            Console.WriteLine(c1.Add(1,2));
            Console.WriteLine(c1.Subtract(2,1));
            Console.WriteLine(c1.Multiply(5,10));
            Console.WriteLine(c1.Power(2, 16));
        }
    }
}
