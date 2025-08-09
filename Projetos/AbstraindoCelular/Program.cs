using System;
using AbstraindoCelular.Models;

namespace AbstraindoCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone iphone = new Iphone
            {
                Nome = "Iphone 14",
                Modelo = "Pro Max",
                IMEI = "123456789012345",
                Memoria = 256
            };

            Console.WriteLine($"Nome: {iphone.Nome}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria} MB");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
            Console.WriteLine();
            Smartphone nokia = new Nokia
            {
                Nome = "Nokia 3310",
                Modelo = "Classic",
                IMEI = "987654321098765",
                Memoria = 16
            };

            Console.WriteLine($"Nome: {nokia.Nome}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria} MB");

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");
            Console.ReadLine();
        }
    }
}
