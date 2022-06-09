using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\leila.contel\source\PAO.txt");
                sw.WriteLine("DAFNE");
                sw.WriteLine("LINDA");

                sw.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finalizando Bloco");
            }


        }
    }
}
