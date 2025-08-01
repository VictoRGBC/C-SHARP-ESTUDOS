namespace ExercicioDeFixacao;

class ContaBancaria
{
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }

    public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
    {
        Deposito(depositoInicial);
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        Saldo -= quantia + 5.0; // Taxa de saque de 5.0
    }

    public override string ToString()
    {
        return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
    }

}