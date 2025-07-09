using System;
using System.Globalization;

namespace DesafioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            int quartos = LerInteiro("Quantos quartos tem na sua casa?");

            double produto = LerDouble("Informe o valor de um produto:");

            Console.WriteLine("Informe seu ultimo nome, idade e altura (mesma linha e com espaços):");
            string[] dados = Console.ReadLine().Split(' ');
            if (dados.Length < 3)
            {
                Console.WriteLine("Entrada inválida. Informe os três dados separados por espaço.");
                return;
            }

            string ultimoNome = dados[0];
            if (!int.TryParse(dados[1], out int idade))
            {
                Console.WriteLine("Idade inválida.");
                return;
            }
            if (!double.TryParse(dados[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double altura))
            {
                Console.WriteLine("Altura inválida.");
                return;
            }

            Console.WriteLine("Nome completo: " + nome);
            Console.WriteLine("Número de quartos: " + quartos);
            Console.WriteLine("Valor do produto: " + produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        static int LerInteiro(string mensagem)
        {
            int valor;
            while (true)
            {
                Console.WriteLine(mensagem);
                if (int.TryParse(Console.ReadLine(), out valor))
                    return valor;
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }

        static double LerDouble(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.WriteLine(mensagem);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                    return valor;
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }
    }
}