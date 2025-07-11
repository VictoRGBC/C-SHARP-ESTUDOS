using System;
using System.Globalization;

namespace Ex2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque(double Preco, int Quantidade)
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int Quantidade)
        {
            return Quantidade += Quantidade;  
        }

        public void RemoverProduto(int Quantidade)
        {
            return Quantidade -= Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", "
                + "R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque(Preco, Quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
