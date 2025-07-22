using System;
using SistemaEstacionamento.Entities;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seja bem-vindo ao sistema de estacionamento!\nDigite o preço inicial: ");
            decimal precoInicial = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o preço por hora: ");
            decimal precoPorHora = decimal.Parse(Console.ReadLine());

            EstacionamentoSistema sistema = new EstacionamentoSistema(precoInicial, precoPorHora);
            sistema.Iniciar();
        }
    }
}
