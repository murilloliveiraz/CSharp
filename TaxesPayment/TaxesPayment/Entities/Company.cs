using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesPayment.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = NumberOfEmployees > 10 ? 14 : 16;
            return AnualIncome * tax / 100;
        }
    }
}
