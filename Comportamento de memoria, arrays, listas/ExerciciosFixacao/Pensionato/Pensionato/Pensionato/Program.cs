using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Pensionato
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quartos[] quartos = new Quartos[10];

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                quartos[numero] = new Quartos(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i]}");
                }
            }
        }
    }
}