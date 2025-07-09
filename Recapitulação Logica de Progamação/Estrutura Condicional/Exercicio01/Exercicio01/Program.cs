using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2);

            Console.WriteLine("Nota Final = " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 60.0)
            {
                Console.WriteLine("Reprovado");
            }

            Console.ReadLine();
        }
    }
}