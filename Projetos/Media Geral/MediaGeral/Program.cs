using MediaGeral.Entities;
using System;

namespace MediaGeral
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";

            Console.Write("Informe a quantidade de alunos: ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int  i = 0;  i < alunos.Length;  i++)
            {
                Console.Write($"Informe o nome do aluno #{i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a quantidade de provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);
                
                Console.WriteLine($"Informe as notas: ");
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;
            Console.WriteLine("Média Geral dos Alunos:");
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} - Média: {aluno.Media:F2}");
                mediaGeral += aluno.Media;
            }

            double mediaFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Média Geral da Turma: {mediaFinal:F2}");
        }
    }
}