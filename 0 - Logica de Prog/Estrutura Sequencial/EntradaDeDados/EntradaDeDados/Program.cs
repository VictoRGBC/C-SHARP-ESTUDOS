using System;

namespace cours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite tres cores:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Digite tres cores separadas por espaços: ");
            //string s = Console.ReadLine(); <-- Linha de comando mais longa
            //string[] cores = s.Split(' '); <-- Linha de comando mais longa

            string[] cores = Console.ReadLine().Split(' '); // Linha de comando mais curta
            string a = cores[0];
            string b = cores[1];
            string c = cores[2];

            Console.WriteLine("Voce digitou:");
            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("Primeira cor: " + x);
            Console.WriteLine("Segunda cor: " + y);
            Console.WriteLine("Terceira cor: " + z);
            Console.WriteLine("Vetor de cores: " + a + ", " + b + ", " + c);
        }
    }
}