using System;
using System.Globalization;

namespace ExerciciooDeFixacao04
{
    class Exercico04
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorDeMoeda.DolarParaReal(cotacao, dolares);
            Console.WriteLine($"Valor a ser pago em reais: {valorEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}