using System.Globalization;

namespace Encap;

class Produto
{
    private string _nome;
    private double Preco { get; private set; }
    private int Quantidade {get; private set;}

    public Produto()
    {
        
    }
    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 0)
            {
                _nome = value;
            }
        }
    }
    
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += Quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= Quantidade;
    }

    public override string ToString()
    {
        return _nome
               + ", $"
               + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantidade
               + " unidades, Total: $ "
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}