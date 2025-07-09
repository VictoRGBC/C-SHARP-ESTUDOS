//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Ex4
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            string[] vet;
//            int x, y;
//            double resultado;

//            for(int i = 0; i < n; i++)
//            {
//                vet = Console.ReadLine().Split(' ');
//                x = int.Parse(vet[0]);
//                y = int.Parse(vet[1]);

//                if (y == 0)
//                {
//                    Console.WriteLine("Divisão impossível");
//                }
//                else
//                {
//                    resultado = (double)x / y;
//                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
//                }
//            }
//        }
//    }
//}
