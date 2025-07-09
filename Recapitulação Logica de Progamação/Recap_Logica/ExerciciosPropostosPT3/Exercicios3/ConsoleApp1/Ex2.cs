//using System;
//using System.Globalization;

//namespace ConsoleApp1
//{
//    internal class Ex2
//    {
//        static void Main(string[] args)
//        {
//            int x, y;

//            string[] vet = Console.ReadLine().Split(' ');
//            x = int.Parse(vet[0]);
//            y = int.Parse(vet[1]);

//            while(x != 0 && y != 0){
//                if (x > 0 && y > 0)
//                {
//                    Console.WriteLine("Primeiro");
//                }
//                else if (x < 0 && y > 0)
//                {
//                    Console.WriteLine("Segundo");
//                }
//                else if (x < 0 && y < 0)
//                {
//                    Console.WriteLine("Terceiro");
//                }
//                else
//                {
//                    Console.WriteLine("Quarto");
//                }
//                vet = Console.ReadLine().Split(' ');
//                x = int.Parse(vet[0]);
//                y = int.Parse(vet[1]);
//            }
//        }
//    }
//}
