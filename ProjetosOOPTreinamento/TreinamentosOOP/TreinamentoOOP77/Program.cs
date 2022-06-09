using System;
using System.Collections.Generic;

namespace TreinamentoOOP77
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando e instanciando a lista
            List<string> list = new List<string>();

            // adicionar elemento do tipo da lista no caso string
            list.Add("Maria");
            list.Add("Anna");
            list.Add("Pedro");
            list.Add("Antonio");
            list.Add("Bob");

            // Insert você define a posição que ele será adicionado
            list.Insert(2, "marco"); // ira empurrar o elemento da posição para baixo e ocupara a posição indicada

            // Imprimindo na tela
            foreach (string obj in list) {
                Console.WriteLine(obj); 
            }
            Console.WriteLine();

            // Para visualizar o tamanho da lista 
            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();

            // Verificando a posição da lista utilizando a função Test para encontrar o primeiro objeto que começe com a letra A
            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);

            // Verificando o primeiro objeto na lista que começe com a letra A
            static bool Test(string s){
                return s[0] == 'A';
            }

            // Substituindo a função por uma expressão lambda
            string s2 = list.Find(x => x[0] == 'A'); // Quero um objeto x tal que x na posição 0 seja igual ao caracter 'A'
            Console.WriteLine("First 'A': " + s2);

            // Para verificar o último elemento da lista com caracter 'A' com lambda
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s3);

            // Encontrar a primeira posição da lista que satisfaça o predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // Encontrar a última posição da lista que satisfaça o predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Filtrar a lista, ou seja criar uma nova lista que contenha apenas um certo predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------------------");
            foreach(string obj in list2){
                Console.WriteLine(obj);
            }

            // Remover elementos da lista
            list.Remove("Anna");
            Console.WriteLine("------------------------------------------");
            foreach(string obj in list){
                Console.WriteLine(obj);
            }

            // Remover um elemento pelo predicato caso não exista o elemento ele apenas não remove
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------------------");
            foreach(string obj in list){
                Console.WriteLine(obj);
            }

            // Remover por uma posição
            list.RemoveAt(3);
            Console.WriteLine("---------------------------------------------");
            foreach(string obj in list){
                Console.WriteLine(obj);
            }

            // Remover os elementos de uma faixa primeiro coloque a partir de qual posição quer remover e depois a quantidade a partir dessa posição a ser removida
            list.RemoveRange(1, 2);
            Console.WriteLine("----------------------------------------------");
            foreach(string obj in list){
                Console.WriteLine(obj);
            }
        }


    }
}
