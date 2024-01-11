using System;
using System.Globalization;
using BancaryAccountExceptions.Entities.Exceptions;

namespace BancaryAccountExceptions.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount) 
        {
            if (amount > WithDrawLimit)
            {
                throw new AccountExceptions("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new AccountExceptions("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"{Number} - {Holder}, Balance R${Balance.ToString("F2", CultureInfo.InvariantCulture)} - WithDraw Limit: {WithDrawLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
