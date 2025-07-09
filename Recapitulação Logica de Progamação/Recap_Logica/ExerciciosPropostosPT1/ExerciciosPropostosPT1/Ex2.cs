using System;
using System.Globalization;

namespace Exercicio2
{
    class EX2
    {
        static void Main(string[] args)
        {
            double r;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(r, 2);

            Console.WriteLine($"Area={area}");
        }
    }
}