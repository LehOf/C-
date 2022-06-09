using System;
using System.Globalization;


namespace ConsoleDesafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebendo o valor do raioO 
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //valor do pi fixo
            double pi = 3.14159;

            //calculo da area
            double area = pi * (Math.Pow(raio,2));


            //Imprimindo resultado da area
            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}


