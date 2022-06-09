using System;

namespace TreinamentoOOP79
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando Matriz

            //int linhas = 2;
            //int colunas = 3;

            //double[,] mat = new double[linhas,colunas];

            //Console.WriteLine(mat.Length); // Quantidade de elementos que têm a matriz
            //Console.WriteLine(mat.Rank); // Ele mostra a quantidade de linhas
            //Console.WriteLine(mat.GetLength(0)); // Ele mostra a dimensão 0 da matriz
            //Console.WriteLine(mat.Length);

            // Quantidade de linhas e colunas
            int N = int.Parse(Console.ReadLine());
            double[,] mat = new double[N, N];

            // Percorrendo a matriz preenchendo os valores
            for (int i = 0; i < N; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("\n" + "Main diagonal");

            // Imprimindo os valores diagonal da matriz
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine("\n");

            // Imprimindo a quantidade de valor negativo
            int count = 0;
            for (int i = 0; i < N; i++){
                for (int j = 0; j < N; j++){
                    if(mat[i,j] < 0){
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers = " + count);

        }
    }
}


