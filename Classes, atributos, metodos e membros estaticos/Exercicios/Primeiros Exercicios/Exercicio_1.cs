// using System;
// using System.Globalization;
//
// namespace Ex_1
// {
//     class EX1
//     {
//         static void Main(string[] args)
//         {
//             Pessoa x, y;
//             x = new Pessoa();
//             y = new Pessoa();
//             
//             Console.WriteLine("Dados da primeira pessoa: ");
//             x.nome = Console.ReadLine();
//             x.idade = int.Parse(Console.ReadLine());
//             
//             Console.WriteLine("Dados da segunda pessoa: ");
//             y.nome = Console.ReadLine();
//             y.idade = int.Parse(Console.ReadLine());
//
//             if (x.idade > y.idade)
//             {
//                 Console.WriteLine($"Pessoa mais velha: {x.nome}");
//             }
//             else
//             {
//                 Console.WriteLine($"Pessoa mais velha: {y.nome}");
//             }
//         }
//     }
// }