using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        int i;
        int j = 7;

        for (i = 1; i <= 9; i = i + 2)
        {
            for (int y = 1; y <= 3; y++)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                j = j - 1;
            }
            j = 7;
        }
    }
}