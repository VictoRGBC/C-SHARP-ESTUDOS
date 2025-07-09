using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioDeFixacao02
{
    class Exercio2
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
