using System;

namespace TreinamentoOOP13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dessa forma no programa principal pode estabelecer vários valores para o parâmetro 
            int S1 = Calculator.Sum(2,3,4,5,6,7,8);
            int S2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(S1);
            Console.WriteLine(S2);
        }
    }
}
