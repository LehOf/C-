using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Treinamento.Entities;
using Treinamento.Entities.Exception;


namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluninho;

            List<Aluno> al = new List<Aluno>();

            Console.Write("Quantos alunos você deseja cadastrar nota: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            try
            {


                for (int i = 0; i < N; i++)
                {
                    Console.Write("Qual nome do aluno: ");
                    string nome = Console.ReadLine();

                    Console.Write("Qual ID do aluno: ");
                    int ID = int.Parse(Console.ReadLine());

                    Console.Write("Digite a primeira nota do aluno: ");
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota < 0.0 || nota > 10.0)
                    {
                        throw new DomainExceptions("NOTA INVÁLIDA");

                    }

                    Console.Write("Digite a segunda nota do aluno: ");
                    double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota < 0.0 || nota > 10.0)
                    {
                        throw new DomainExceptions("NOTA INVÁLIDA");

                    }

                    Console.Write("Digite a terceira nota do aluno: ");
                    double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota < 0.0 || nota > 10.0)
                    {
                        throw new DomainExceptions("NOTA INVÁLIDA");

                    }

                    aluninho = new Aluno(nome, ID, nota, nota2, nota3);
                    aluninho.Media();
                    al.Add(aluninho);

                    Console.WriteLine("");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            foreach (Aluno i in al)
            {
                Console.WriteLine(i);
            }
        }

    }
}

