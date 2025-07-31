using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral.Entities
{
    class Aluno
    {
        public string Nome { get; private set; }
        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.WriteLine($"Nota #{i + 1}");
                Console.Write($"Informe a nota da prova {i + 1}: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double soma = 0;

            for (int i = 0; i < _notas.Length; i++)
            {
                soma += _notas[i];
            }

            return soma / _notas.Length;
        }
    }
}
