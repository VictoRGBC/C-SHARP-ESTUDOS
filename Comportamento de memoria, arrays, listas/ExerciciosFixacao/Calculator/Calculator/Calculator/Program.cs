using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2, 3);
            int s2 = Calculator.Sum( 4, 5, 6 );

            Console.WriteLine($"Sum 1: {s1}");
            Console.WriteLine($"Sum 2: {s2}");
        }
    }
}