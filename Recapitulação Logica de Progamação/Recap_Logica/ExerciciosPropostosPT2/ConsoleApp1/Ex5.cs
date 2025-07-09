//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Ex5
//    {
//        static void Main(string[] args)
//        {
//            int codigo, quantidade;
//            double total = 0.0;

//            string[] vet = Console.ReadLine().Split(' ');
//            codigo = int.Parse(vet[0]);
//            quantidade = int.Parse(vet[1]);

//            if (codigo == 1)
//            {
//                total = quantidade * 4.00;
//            }
//            else if (codigo == 2)
//            {
//                total = quantidade * 4.50;
//            }
//            else if (codigo == 3)
//            {
//                total = quantidade * 5.00;
//            }
//            else if (codigo == 4)
//            {
//                total = quantidade * 2.00;
//            }
//            else if (codigo == 5)
//            {
//                total = quantidade * 1.50;
//            }
//            else
//            {
//                Console.WriteLine("Código inválido");
//                return;

//            }

//            Console.WriteLine($"Total: {total.ToString("F2")}");
//        }
//    }
//}
