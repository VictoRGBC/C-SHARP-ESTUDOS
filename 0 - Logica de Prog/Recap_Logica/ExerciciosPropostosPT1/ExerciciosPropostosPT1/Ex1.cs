using System;
using System.Globalization;

namespace Exercicio1
{
    class EX1
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}

