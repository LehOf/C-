using System;
using System.Globalization;

namespace TreinamentoOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaciando
            Salario pessoa1 = new Salario();
            Salario pessoa2 = new Salario();

            // Pegando dados da primeira pessoa
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Pegando dados da segunda pessoa
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Consultando média salarial
            double media = (pessoa1.valor + pessoa2.valor) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
