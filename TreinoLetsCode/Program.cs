using System;

namespace TreinoLetsCode
{
    public class Program
    {
        public static void Main(String[] args)
        {

            Random gerador = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(gerador.Next(101));
            }
        }
    }
}





