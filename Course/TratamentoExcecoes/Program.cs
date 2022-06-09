using System;
using Course.Entities;
using TratamentoExcecoes.Entities.Exceptions;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double witdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Account conta = new Account(number, holder, initialBalance, witdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double Witdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                conta.Witdraw(Witdraw);
                Console.WriteLine("New balance: " + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}