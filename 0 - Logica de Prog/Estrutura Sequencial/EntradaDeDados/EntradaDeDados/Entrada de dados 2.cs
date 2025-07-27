using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Entrada_de_dados_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu sexo F ou M: ");
            char ch = char.Parse(Console.ReadLine()[0]);

            Console.WriteLine("Sua idade: " + n1);
            Console.WriteLine("Sexo: " + ch);
        }
    }
}
