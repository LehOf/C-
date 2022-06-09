using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int m = int.Parse(s[0]);
        int n = int.Parse(s[1]);

        int[,] mat = new int[m, n];

        for(int i=0; i<m; i++)
        {
            string[] v = Console.ReadLine().Split(' ');

            for(int j=0; j<n; j ++)
            {

                mat[i, j] = int.Parse(v[j]);
            }
        }
        Console.WriteLine("VALORES NEGATIVOS: ");
        for(int i = 0; i<m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                if(mat[i,j] < 0)
                {
                    Console.WriteLine(mat[i, j]);
                }
                
            }
            
            
        }


        


        Console.ReadLine();
    }
}

