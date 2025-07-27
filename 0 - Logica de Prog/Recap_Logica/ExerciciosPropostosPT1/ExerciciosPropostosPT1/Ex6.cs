using System;
using System.Globalization;

namespace Exercicio2
{
    class EX2
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int quantidade1 = int.Parse(vet1[1]);
            double preco1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int quantidade2 = int.Parse(vet2[1]);
            double preco2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = (quantidade1 * preco1) + (quantidade2 * preco2);

            Console.WriteLine($"Valor a pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}