//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Ex4
//    {
//        static void Main(string[] args)
//        {
//            int horaini, horafinal;

//            string[] vet = Console.ReadLine().Split(' ');
//            horaini = int.Parse(vet[0]);
//            horafinal = int.Parse(vet[1]);

//            if (horaini < 0 || horafinal < 0 || horaini > 23 || horafinal > 23)
//            {
//                Console.WriteLine("Hora inválida");
//            }
//            else if (horaini == horafinal)
//            {
//                Console.WriteLine("O jogo durou 24 horas");
//            }
//            else if (horaini < horafinal)
//            {
//                Console.WriteLine($"O jogo durou {horafinal - horaini} horas");
//            }
//            else
//            {
//                Console.WriteLine($"O jogo durou {24 - horaini + horafinal} horas");
//            }
//        }
//    }   
//}
