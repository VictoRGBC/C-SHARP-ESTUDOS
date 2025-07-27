using System;
using System.Globalization;


namespace Banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double valor) : this(numero, nome)
        {
            Deposito(valor);
        }

        public void Deposito(double valor)
        {
            Valor += valor;
        }

        public void Saque(double valor)
        {
            Valor -= valor + 5.0; // Deduzindo taxa de saque
        }


        public override string ToString()
        {

            return $"Conta: {Numero}, Nome: {Nome}, Valor: {Valor.ToString("F2", CultureInfo.CurrentCulture)}";  
        }
    }
}
