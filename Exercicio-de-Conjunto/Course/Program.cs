using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alunosA = new HashSet<int>();
            HashSet<int> alunosB = new HashSet<int>();
            HashSet<int> alunosC = new HashSet<int>();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            int Id = 0;


            for (int i = 0; i < n; i++)
            {
                Id = int.Parse(Console.ReadLine());
                alunosA.Add(Id);
            }

            Console.Write("How many students for course B?");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                Id = int.Parse(Console.ReadLine());
                alunosB.Add(Id);
            }

            Console.Write("How many students for course C?");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {
                Id = int.Parse(Console.ReadLine());
                alunosC.Add(Id);
            }
            HashSet<int> uniao = new HashSet<int>(alunosA);
            uniao.UnionWith(alunosB);
            uniao.UnionWith(alunosC);
            
            Console.WriteLine("Total students: " + uniao.Count);


        }
    }
}
