using System;
using restricoesGenerics.entities;
using System.Collections.Generic;

namespace restricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // Criando lista
            List<Product> list = new List<Product>(); 

           
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(",");
                string nome = vet[0];
                double price = double.Parse(vet[1]);

                list.Add(new Product(nome, price));
                
            }

            CalculationService calculation = new CalculationService();

            Product p = calculation.Max(list);

            Console.WriteLine("MAX: ");
            Console.WriteLine(p);
            
        }
    }
}
