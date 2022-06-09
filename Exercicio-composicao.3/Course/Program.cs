using System;
using Course.Entities.Enum;
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Birth data: dd/MM/yyyy ");
            DateTime birthdata = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();


            Client c1 = new Client(name, email, birthdata);
            Order order = new Order(DateTime.Now, status, c1);
            Console.WriteLine();

           
            Console.Write("How many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string Name = Console.ReadLine();
                Console.Write("Product price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product produto = new Product(Name, Price);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                OrderItem ordem = new OrderItem(Quantity, Price, produto);
                
                order.Additem(ordem);

                Console.WriteLine();

            }

            Console.WriteLine(order);

        }
    }
}
