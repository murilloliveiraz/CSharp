using System;
using System.Globalization;

namespace ContractProcessor.Entitites
{
    internal class Installment
    {
        private DateTime dueDate { get; set; }
        private double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{dueDate.ToString("dd/MM/yyyy")} - R${amount.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
