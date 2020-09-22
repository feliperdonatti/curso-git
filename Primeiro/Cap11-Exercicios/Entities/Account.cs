using Cap11_Exercicios.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11_Exercicios.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("O valor precisa ser maior que zero");
            }

            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");

            }

            Balance -= amount;
        }

    }
}
