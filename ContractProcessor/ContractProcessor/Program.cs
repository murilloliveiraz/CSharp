using ContractProcessor.Entitites;
using ContractProcessor.Services;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, contractValue); 

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);
            Console.WriteLine("Installments");
            Console.WriteLine(contract);
        }
    }
}
