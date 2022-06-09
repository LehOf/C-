using System;
using System.Collections.Generic;
using System.Text;
using TratamentoExcecoes.Entities.Exceptions;

namespace Course.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WitdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double witdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WitdrawLimit = witdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Witdraw(double amount)
        {
            if (amount > WitdrawLimit)
            {
                throw new DomainExceptions("Withdraw error: The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainExceptions("Withdraw error: Not enough balance ");
            }

            Balance -= amount;


        }
    }
}