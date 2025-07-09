using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Entrada_de_dados_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu sexo F ou M: ");
            char ch = char.Parse(Console.ReadLine()[0]);

            Console.WriteLine("Digite um vetor de 4 elementos: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Sua idade: " + n1);
            Console.WriteLine("Sexo: " + ch);
            Console.WriteLine("Vetor: " + nome + sexo + idade + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
