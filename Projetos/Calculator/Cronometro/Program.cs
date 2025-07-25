using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Stopwatch!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("S. For seconds: ");
            Console.WriteLine("M. For minutes: ");
            Console.WriteLine("E. Exit: ");
            Console.WriteLine("How Many time? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60; // Convert minutes to seconds
            }

            if(time == 'e')
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000); // Wait for 1 second
            Console.WriteLine("Set...");
            Thread.Sleep(1000); // Wait for 1 second
            Console.WriteLine("Go!");
            Thread.Sleep(2500); // Wait for 1 second

           Start(time);
        }

        static void Start(int time)
        {
            
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Current time: {currentTime} seconds");

                Thread.Sleep(1000); // Sleep for 1 second
            }

            Console.Clear();
            Console.WriteLine("Time's up!");
            Thread.Sleep(2000); // Wait for 2 seconds before exiting

            Menu();
        }
    }
}