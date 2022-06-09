using System;

namespace TreinamentoOOP90
{
    class Program
    {
        static void Main(string[] args)
        {
            // MUITO USADO PARA CALCULAR MUTA E JUROS 

            // DEMONSTRAÇÃO CONSTRUTORES
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            // DEMONSTRAÇÃO MÉTODO FROM
            TimeSpan T1 = TimeSpan.FromDays(1.5);
            TimeSpan T2 = TimeSpan.FromHours(1.5);
            TimeSpan T3 = TimeSpan.FromMinutes(1.5);
            TimeSpan T4 = TimeSpan.FromSeconds(1.5);
            TimeSpan T5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan T6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
            Console.WriteLine(T4);
            Console.WriteLine(T5);
            Console.WriteLine(T6);
        }
    }
}
