using System;
using System.Globalization;

namespace Banco
{
    class program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("Digite o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta:");
            string nome = Console.ReadLine();
            Console.WriteLine("Havera deposito incial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Digite o valor do deposito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Digite um valor para deposito:");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Digite um valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

        }
    }
}