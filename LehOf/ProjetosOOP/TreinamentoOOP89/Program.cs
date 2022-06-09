using System;
using System.Globalization;

namespace TreinamentoOOP89
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para visualizar a data e a hora
            DateTime a = DateTime.Now;
            Console.WriteLine(a);

            // Quantidade de monosegundos da meia noite da era atual até a data de hoje
            Console.WriteLine(a.Ticks);

            // Instanciando um DateTime
            DateTime d1 = new DateTime(2021, 12, 22); // data
            DateTime d2 = new DateTime(2021, 12, 22, 17, 42, 35); // data e hora

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            // DateTimeKind - saber se é hora local ou global
            // Hora local fuso horario meia noite GNT

            // Utilizando os Builders
            DateTime d3 = DateTime.Now; // Data e hora de agora
            DateTime d4 = DateTime.Today; // Data de hoje hora zerada
            DateTime d5 = DateTime.UtcNow; // Hora de agora universal

            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            // Data conversão de string para DateTime
            DateTime d6 = DateTime.Parse("2021-12-22");
            DateTime d7 = DateTime.Parse("2021-12-22 17:49:02");
            DateTime d8 = DateTime.Parse("2021/12/22 17:50:08");
            DateTime d9 = DateTime.ParseExact("2021-12-22","yyyy-MM-dd",CultureInfo.InvariantCulture); // Para determinar o formato da data
            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);


            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);






        }
    }
}
