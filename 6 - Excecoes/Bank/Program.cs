using System;
using Bank.Entities;
using Bank.Entities.Exceptions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter account holder: ");
            string holder = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Enter withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                account.Withdraw(amount);
                Console.WriteLine(account);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
        }
    }
}