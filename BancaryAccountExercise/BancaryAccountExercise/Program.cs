using System;
using System.Globalization;

namespace BancaryAccountExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;
            Console.WriteLine("========= BANCO =========");
            Console.WriteLine("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string name = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double initialValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(name, accountNumber, initialValue);
                Console.WriteLine(account);
            } else
            {
                account = new Account(name, accountNumber);
                Console.WriteLine(account);
            }
            Console.WriteLine("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.addBalance(deposit);
            Console.WriteLine("Dados atualizados da conta: "+ account);

            Console.WriteLine("Entre um valor para saque: ");
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.withdrawBalance(withDraw);
            Console.WriteLine("Dados atualizados da conta: " + account);
        }
    }
}
