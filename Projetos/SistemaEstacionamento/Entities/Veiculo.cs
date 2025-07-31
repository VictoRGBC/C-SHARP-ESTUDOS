namespace SistemaEstacionamento.Entities
{
    class Veiculo
    {
        public string Nome { get; set; }
        public int Numero { get; set; }

        public Veiculo(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Número: {Numero}";
        }
    }
}
