using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
                printService.CompareTo(x);
               
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            Console.WriteLine("O maior valor é: " + printService.CompareTo(x));

        }
    }
}
