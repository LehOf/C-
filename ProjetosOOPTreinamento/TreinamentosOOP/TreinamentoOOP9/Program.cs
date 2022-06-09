using System;
using System.Globalization;

namespace TreinamentoOOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;

            // Pegando dados
            Console.Write("Entre o número da conta: ");
            int numero = (int)Convert.ToInt64(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            // Condição para verificar se a depósito inicial
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                saldo = 0.00;
            }

            // --Instanciação do objeto
            ContaBancaria cc = new ContaBancaria(numero, titular, saldo);
            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + "\n" + cc) ;
            Console.WriteLine();

            // --Fazendo o depósito
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cc.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: " + "\n" + cc);
            Console.WriteLine();

            // --Fazendo o saque
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cc.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: " + "\n" + cc);


        }
    }
}

