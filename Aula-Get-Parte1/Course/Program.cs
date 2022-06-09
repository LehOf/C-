using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService printService = new PrintService();

            Console.WriteLine("Quantos valores você vai digitar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                printService.AddValue(valor);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            
        }
    }
}