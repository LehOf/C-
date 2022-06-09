using System;
namespace TreinoIFRS
{
    class Program
    {
        private const int V = 4;

        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 4 }, { 4, 4, 4 } };

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (x % 2 == 0 & (y % 2 == 0))
                    {
                        Console.WriteLine(matriz[x, y]);
                    }
                }
            }
        }
    }
}







