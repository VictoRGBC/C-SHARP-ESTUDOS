using System;
using System.Globalization;

namespace CalculadoraDeImc
{
    class program
    {
        static void Main(string[] args)
        {
            double peso, altura;

            Console.WriteLine("Digite seu peso em kg:");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite sua altura em metros:");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IMC imc = new IMC();

            double resultado = imc.CalculadoraDeImc(peso, altura);

            Console.WriteLine($"Seu IMC é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}