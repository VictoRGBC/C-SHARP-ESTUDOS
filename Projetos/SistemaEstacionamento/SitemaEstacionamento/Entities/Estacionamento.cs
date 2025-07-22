using System;
using System.Collections.Generic;

namespace SistemaEstacionamento.Entities
{
    class EstacionamentoSistema
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<Veiculo> veiculos;

        public EstacionamentoSistema(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
            veiculos = new List<Veiculo>();
        }

        public void Iniciar()
        {
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opcao:");
                Console.WriteLine("1 - Cadastrar veiculo");
                Console.WriteLine("2 - Remover veiculo");
                Console.WriteLine("3 - Listar veiculos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        CadastrarVeiculo();
                        break;
                    case "2":
                        RemoverVeiculo();
                        break;
                    case "3":
                        ListarVeiculos();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida. Pressione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void CadastrarVeiculo()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número do veículo: ");
            int numero = int.Parse(Console.ReadLine());

            veiculos.Add(new Veiculo(nome, numero));
            Console.WriteLine("Veículo cadastrado com sucesso! Pressione Enter para continuar...");
            Console.ReadLine();
        }

        private void RemoverVeiculo()
        {
            Console.Write("Digite o número do veículo a ser removido: ");
            int numero = int.Parse(Console.ReadLine());

            Veiculo veiculo = veiculos.Find(v => v.Numero == numero);
            if (veiculo != null)
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);
                Console.WriteLine($"O veiculo {veiculo} foi removido e o valor total a pagar sera: R${valorTotal:F2}");
                veiculos.Remove(veiculo);
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }

        private void ListarVeiculos()
        {
            Console.WriteLine("Lista de veículos:");
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
