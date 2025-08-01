﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExercicoFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preco e $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco e $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            Console.WriteLine($"Separado decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}