using System;
using System.Collections.Generic;

namespace Sistema.Entities
{
    class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; } = new List<Pessoa>();
        public Suite Suite { get; private set; }
        public DateTime DataEntrada { get; private set; }

        // Métodos originais
        public bool CadastrarHospede(string nome, string sobrenome)
        {
            if (Suite == null)
                throw new InvalidOperationException("Nenhuma suíte cadastrada.");

            if (Hospedes.Count >= Suite.Capacidade)
                return false;

            Pessoa hospede = new Pessoa(nome, sobrenome);
            Hospedes.Add(hospede);
            return true;
        }

        public void CadastrarSuite(string tipo, int capacidade, decimal valorDiaria)
        {
            Suite = new Suite(tipo, capacidade, valorDiaria);
        }

        public void DefinirDataEntrada(string dataEntradaStr)
        {
            if (!DateTime.TryParseExact(dataEntradaStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataEntrada))
            {
                throw new ArgumentException("Data inválida. Use o formato dd/MM/yyyy.");
            }
            DataEntrada = dataEntrada;
        }

        public decimal CalcularValorDiariaPorDias(int quantidadeDias)
        {
            if (Suite == null)
                throw new InvalidOperationException("Nenhuma suíte cadastrada.");

            if (DataEntrada == default)
                throw new InvalidOperationException("Data de entrada não definida.");

            if (quantidadeDias <= 0)
                throw new ArgumentException("A quantidade de dias deve ser maior que zero.");

            DateTime dataSaida = DataEntrada.AddDays(quantidadeDias);

            decimal valorDiaria = Suite.ValorDiaria;
            if (quantidadeDias >= 10)
                valorDiaria *= 0.9m; // desconto 10%

            return quantidadeDias * valorDiaria;
        }


        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // ------ Menu interativo ------

        private void ExibirMenu()
        {
            Console.WriteLine("===== Sistema de Reserva =====");
            Console.WriteLine("1 - Cadastrar Suíte");
            Console.WriteLine("2 - Cadastrar Hóspede");
            Console.WriteLine("3 - Definir Data de Entrada");
            Console.WriteLine("4 - Calcular Valor da Diária");
            Console.WriteLine("5 - Mostrar Quantidade de Hóspedes");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
        }

        public void ExecutarMenu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                ExibirMenu();

                string opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            MenuCadastrarSuite();
                            break;
                        case "2":
                            MenuCadastrarHospede();
                            break;
                        case "3":
                            MenuDefinirDataEntrada();
                            break;
                        case "4":
                            MenuCalcularValorPorDias();
                            break;
                        case "5":
                            MenuMostrarQuantidadeHospedes();
                            break;
                        case "6":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            Pausar();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    Pausar();
                }
            }
        }

        private void MenuCadastrarSuite()
        {
            Console.Clear();
            Console.WriteLine("== Cadastro de Suíte ==");

            Console.Write("Tipo da suíte: ");
            string tipo = Console.ReadLine();

            Console.Write("Capacidade: ");
            string capacidadeStr = Console.ReadLine();

            Console.Write("Valor da diária: ");
            string valorStr = Console.ReadLine();

            if (!int.TryParse(capacidadeStr, out int capacidade))
            {
                Console.WriteLine("Capacidade inválida.");
                Pausar();
                return;
            }
            if (!decimal.TryParse(valorStr, out decimal valor))
            {
                Console.WriteLine("Valor inválido.");
                Pausar();
                return;
            }

            CadastrarSuite(tipo, capacidade, valor);
            Console.WriteLine("Suíte cadastrada com sucesso!");
            Pausar();
        }

        private void MenuCadastrarHospede()
        {
            Console.Clear();
            if (Suite == null)
            {
                Console.WriteLine("Você precisa cadastrar uma suíte antes de cadastrar hóspedes.");
                Pausar();
                return;
            }

            Console.WriteLine("== Cadastro de Hóspede ==");
            Console.Write("Nome do hóspede: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome do hóspede: ");
            string sobrenome = Console.ReadLine();

            bool sucesso = CadastrarHospede(nome, sobrenome);

            if (sucesso)
                Console.WriteLine("Hóspede cadastrado com sucesso!");
            else
                Console.WriteLine("Não foi possível cadastrar hóspede: capacidade máxima atingida.");

            Pausar();
        }

        private void MenuDefinirDataEntrada()
        {
            Console.Clear();
            Console.WriteLine("== Definir Data de Entrada ==");
            Console.Write("Data de entrada (dd/MM/yyyy): ");
            string dataEntrada = Console.ReadLine();

            DefinirDataEntrada(dataEntrada);
            Console.WriteLine("Data de entrada definida!");
            Pausar();
        }


        private void MenuCalcularValorPorDias()
        {
            Console.Clear();
            if (Suite == null)
            {
                Console.WriteLine("Nenhuma suíte cadastrada.");
                Pausar();
                return;
            }
            if (DataEntrada == default)
            {
                Console.WriteLine("Defina a data de entrada primeiro.");
                Pausar();
                return;
            }

            Console.WriteLine("== Calcular Valor da Diária por quantidade de dias ==");
            Console.Write("Digite a quantidade de dias da estadia: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int dias) || dias <= 0)
            {
                Console.WriteLine("Quantidade de dias inválida.");
                Pausar();
                return;
            }

            decimal valor = CalcularValorDiariaPorDias(dias);
            DateTime dataSaida = DataEntrada.AddDays(dias);
            Console.WriteLine($"Data de saída calculada: {dataSaida:dd/MM/yyyy}");
            Console.WriteLine($"Valor total da estadia: R$ {valor:F2}");
            Pausar();
        }


        private void MenuMostrarQuantidadeHospedes()
        {
            Console.Clear();
            Console.WriteLine("== Quantidade de Hóspedes ==");
            Console.WriteLine($"Número de hóspedes cadastrados: {ObterQuantidadeHospedes()}");
            Pausar();
        }

        private void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
