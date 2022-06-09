using System;
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listas
            List<Product> produto = new List<Product>();


            // Instanciação dos objetos
            Product p1 = new ImportedProduct();
            Product p2 = new UsedProduct();

            Console.WriteLine("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Product #" + i + " data: ");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                string resposta = Console.ReadLine();

                if (resposta == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct produtoImportado2 = new ImportedProduct(name, price, customsFee);
                    produto.Add(produtoImportado2);
                }
                else if (resposta == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product produto2 = new Product(name, price);
                    produto.Add(produto2);
                }
                else if (resposta == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date(DD/ MM / YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct produtoUsado2 = new UsedProduct(name, price, date);
                    produto.Add(produtoUsado2);
                }
                Console.WriteLine("");
            }

            foreach(Product p in produto)
            {
                Console.WriteLine("PRICE TAGS: ");
                Console.WriteLine(p.PriceTag());
            }


 

        }
    }
}
