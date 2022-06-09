using System;
using System.Collections.Generic;
using TreinamentoWeb.Entities;

namespace TreinamentoWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ItemOrcamentoComplexo> lista = new List<ItemOrcamentoComplexo>();
            ItemOrcamentoComplexo item;
            ItemOrcamentoComplexo item2;


            Console.WriteLine("Digite o número de vezes que gostaria de entrar com o tipo do Animal e o orçamento: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {

                Console.Write("O animal possui vacina 'W'? ");
                char resposta = Convert.ToChar(Console.ReadLine());

                if (resposta == 'S')
                {
                    Console.Write("Nome do animal: ");
                    string Animal = Console.ReadLine();
                    Console.Write("Orçamento: ");
                    double Orcamento = double.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------");
                    item = new ItemOrcamentoComplexo(Animal, Orcamento);
                    lista.Add(item);
                    item.orcamentoGastosAnimal(lista, item);
                    Console.WriteLine("ORÇAMENTO PARA ANIMAL COM VACINA 'W': ");

                    foreach (ItemOrcamentoComplexo c in lista)
                    {

                        Console.WriteLine(c);
                    }


                }
                else if (resposta == 'N')
                {
                    Console.Write("Nome do animal: ");
                    string Animal = Console.ReadLine();
                    Console.Write("Orçamento: ");
                    double Orcamento = double.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------");
                    item = new ItemOrcamentoComplexo(Animal, Orcamento);
                    lista.Add(item);
                    item.orcamentoGastosAnimal(lista, item);
                    Console.WriteLine("ORÇAMENTO PARA ANIMAL SEM VACINA 'W': ");

                    foreach (ItemOrcamentoComplexo c in lista)
                    {

                        Console.WriteLine(c);
                    }

                }





            }










        }
    }
}
