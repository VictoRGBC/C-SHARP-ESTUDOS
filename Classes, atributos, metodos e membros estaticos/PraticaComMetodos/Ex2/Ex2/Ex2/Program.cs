using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}