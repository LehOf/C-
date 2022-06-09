using System;
using System.Collections.Generic;
using System.Globalization;

namespace TreinamentoOOP78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= N; i++)
            { // Percorrendo a lista
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: "); // Pegando ID
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: "); // Pegando Nome
                string name = Console.ReadLine();
                Console.Write("Salary: "); // Pegando salario
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary)); // Atribuindo valores para lista Employee 1
                Console.WriteLine();
            }

            // Verificando se existe algum ID igual
            Console.WriteLine("Enter the employee id that will have salary increase :");
            int valorId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == valorId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            // Imprimindo lista
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }


    }
}

