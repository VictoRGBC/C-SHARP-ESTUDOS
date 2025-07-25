using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("-------------------------------");

            Console.Write("Selected option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Subtract();
                    break;
                case "3":
                    Multiply();
                    break;
                case "4":
                    Divide();
                    break;
                case "5":
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    ShowMenu();
                    break;
            }
        }

        static void Add()
        {
            Console.Clear();

            Console.Write("Please enter the first number:");
            float firstNumbe = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = firstNumbe + secondNumber;
            Console.WriteLine($"The result of adding {firstNumbe} and {secondNumber} is: {resultado}");

            Console.ReadKey();
        }

        static void Subtract()
        {
            Console.Clear();

            Console.Write("Please enter the first number:");
            float firstNumbe = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float resultado = firstNumbe - secondNumber;
            Console.WriteLine($"The result of subtracting {secondNumber} from {firstNumbe} is: {resultado}");

            ShowMenu();
            Console.ReadKey();
        }

        static void Multiply()
        {
            Console.Clear();

            Console.Write("Please enter the first number:");
            float firstNumbe = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float resultado = firstNumbe * secondNumber;
            Console.WriteLine($"The result of multiplying {firstNumbe} and {secondNumber} is: {resultado}");

            ShowMenu();
            Console.ReadKey();
        }

        static void Divide()
        {
            Console.Clear();

            Console.Write("Please enter the first number:");
            float firstNumbe = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine();
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                float resultado = firstNumbe / secondNumber;
                Console.WriteLine($"The result of dividing {firstNumbe} by {secondNumber} is: {resultado}");
            }

            ShowMenu();
            Console.ReadKey();
        }
    }
}