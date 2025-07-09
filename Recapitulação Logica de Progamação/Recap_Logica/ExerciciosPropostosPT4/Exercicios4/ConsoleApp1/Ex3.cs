//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

//namespace ConsoleApp1
//{
//    internal class Ex3
//    {
//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            string[] vet;
//            double n1, n2, n3, media = 0.0;


//            for (int i =1; i <= N; i++)
//            {
//                vet = Console.ReadLine().Split(' ');
//                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
//                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
//                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

//                media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 5)) / 10;

//                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
//            }
//        }
//    }
//}
