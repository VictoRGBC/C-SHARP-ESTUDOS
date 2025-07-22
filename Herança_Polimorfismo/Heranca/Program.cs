using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
             Account acc = new Account(1001, "Alex", 500.0);
             BusinessAcount bacc = new BusinessAcount(1002, "Maria", 500.0, 400.0);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAcount(1003, "Bob", 500.0, 200.0);
            Account acc3 = new SavingsAcount(1004, "Anna", 500.0, 0.01);

            // Downcasting

            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100.0);
            
            if (acc3 is BusinessAcount)
            {
                BusinessAcount acc5 = (BusinessAcount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAcount)
            {
                SavingsAcount acc6 = (SavingsAcount)acc3;
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}