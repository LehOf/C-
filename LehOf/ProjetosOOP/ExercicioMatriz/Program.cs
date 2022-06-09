using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guardando valores M(LINHAS) e N(COLUNAS)
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            // Declarando e instanciando a matriz
            int[,] mat = new int[M, N];

            // Preenchendo a matriz
            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);

                }
            }
            Console.WriteLine();

            // Pegar o valor de X
            Console.WriteLine("Digite o valor do X: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine();
            // Impirmir a posição de x e os valores ao arredor
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (X == mat[i, j])
                    {
                        Console.WriteLine("Position: " + i + ", " + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
