using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TaxesPayment.Entities;

namespace TaxesPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payersList = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers:");
            int payers = int.Parse(Console.ReadLine());
            for (int i = 0; i < payers; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.WriteLine("Individual or company (i/c)?");
                char typeOfPerson = char.Parse(Console.ReadLine());

                if(typeOfPerson == 'i')
                {
                    Console.Write("Name :");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    Individual individual = new Individual(name, anualIncome, healthExpenditure);
                    payersList.Add(individual);
                } else
                {
                    Console.Write("Name :");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees:");
                    int employees = int.Parse(Console.ReadLine());
                    Company company = new Company(name, anualIncome, employees);
                    payersList.Add(company);
                }

            }
            foreach (TaxPayer Payer in payersList)
            {
               Console.WriteLine($"{Payer.Name}: ${Payer.Tax()}");
            }
        }
    }
}
