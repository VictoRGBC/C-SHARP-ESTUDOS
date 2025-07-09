using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int x, a = 0, g = 0, d = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                if (x == 1)
                {
                    a++;
                }
                else if (x == 2)
                {
                    g++;
                }
                else if (x == 3)
                {
                    d++;
                }
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + g);
            Console.WriteLine("Diesel: " + d);  

        }
    }
}
