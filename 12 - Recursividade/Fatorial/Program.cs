using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de" + n + " é " + Fatorial(n));

            Console.ReadKey();
        }

        static int Fatorial(int n)
        {
            if ( n <= 0 )
            {
                return 1;
            }
            return n * Fatorial(n - 1);
        }
    }
}