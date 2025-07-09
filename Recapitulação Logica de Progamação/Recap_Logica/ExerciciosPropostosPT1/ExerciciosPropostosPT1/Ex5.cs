using System;
using System.Globalization;

namespace Exercicio2
{
    class EX2
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture); 
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2.0;
            double circulo = 3.14159 * Math.Pow(C,2);
            double trapezio = ((A + B) * C) / 2.0;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"Triangulo: {triangulo:F3}");
            Console.WriteLine($"Circulo: {circulo:F3}");    
            Console.WriteLine($"Trapezio: {trapezio:F3}"); 
            Console.WriteLine($"Quadrado: {quadrado:F3}");
            Console.WriteLine($"Retangulo: {retangulo:F3}");

        }
    }
}