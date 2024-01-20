using System;
using System.Globalization;

namespace CarRentalInterfaces.Entities
{
    internal class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }

        public double TotalPayment
        {
            get { return basicPayment + tax; }
        }

        public override string ToString()
        {
            return $"\nBasic Payment: {basicPayment.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"\n Tax: {tax.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"\n Total Payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
