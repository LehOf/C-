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
            List<Employee> employee = new List<Employee>();

            Employee employee1 = new OutSourceEmployee();

            Console.Write("Enter the number of employee: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + "");
                Console.WriteLine("Outsourced (y/n)? ");
                string resposta = Console.ReadLine();
                if (resposta == "y")
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int Hours = int.Parse(Console.ReadLine());
                    Console.Write("ValuePerHours: ");
                    double ValuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee2 = new OutSourceEmployee(Name, Hours, ValuePerHours, adicional);
                    employee.Add(employee2);
                }
                else
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int Hours = int.Parse(Console.ReadLine());
                    Console.Write("ValuePerHours: ");
                    double ValuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee3 = new Employee(Name, Hours, ValuePerHours);
                    employee.Add(employee3);


                }
                Console.WriteLine("");
            }

            foreach (Employee c in employee)
            {
                Console.WriteLine(c);
            }
    
        }
    }
}
