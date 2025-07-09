using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, valor, area, preco;

            Console.WriteLine("Digite a medida de largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a medida de comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do metro quadrado do terreno: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = valor * area;

            Console.WriteLine("A area do terreno e: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preco do terreno e: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}