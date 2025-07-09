using System;
using System.Globalization;
using Ex_1;
using Primeiros_Exercicios;

namespace Ex_2
{
    class EX2
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            
            Console.WriteLine("Insira o nome do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados do segundo funcinario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());
            
            double mSalario = (double)(f1.Salario + f2.Salario)/2;
            
            Console.WriteLine($"Salario medio = {mSalario:F2}");
        }
    }
}