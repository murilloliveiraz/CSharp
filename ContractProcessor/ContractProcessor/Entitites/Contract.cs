using System;
using System.Collections.Generic;

namespace ContractProcessor.Entitites
{
    internal class Contract
    {
        public int number { get; private set; }
        public  DateTime date { get; private set; }
        public double totalValue { get; private set; }
        public List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public override string ToString()
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (Installment installment in installments)
            {
                result.AppendLine(installment.ToString());
            }
            return result.ToString();
        }
    }
}
