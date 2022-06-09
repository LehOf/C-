using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            string linha;
            StreamReader stream = new StreamReader(@"C:\Users\leila.contel\source\PAO.txt");

            try
            {
                linha = stream.ReadLine();

                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = stream.ReadLine();
                }

                stream.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
        }
    }
}

