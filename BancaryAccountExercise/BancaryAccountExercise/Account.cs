using System;
using System.Globalization;

namespace BancaryAccountExercise
{
    internal class Account
    {
        public string Name { get; set; }
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string nome, int accountNumber)
        {
            Name = nome;
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public Account(string nome, int accountNumber, double initialDeposit) : this(nome, accountNumber)
        {
            addBalance(initialDeposit);
        }

        public string Nome
        {
            get { return Name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    Name = value;
                }
            }
        }

        public void addBalance(double value)
        {
            Balance += value;
        }
        public void withdrawBalance(double value)
        {
            double tax = 5.00;
            Balance -= value + tax;
        }

        public override string ToString()
        {
            return "Numero da Conta : " 
                + AccountNumber 
                + "\n Nome :"
                + Name 
                + "\n Saldo: $" 
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
