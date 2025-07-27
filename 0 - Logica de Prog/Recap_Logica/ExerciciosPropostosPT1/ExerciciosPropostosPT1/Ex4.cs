using System;
using System.Globalization;

namespace Exercicio2
{
    class EX2
    {
        static void Main(string[] args)
        {
            int codigoFunc, horas;
            double valorHora, salario;

            codigoFunc = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorHora;

            Console.WriteLine($"Numero = {codigoFunc}");
            Console.WriteLine("Salario = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}