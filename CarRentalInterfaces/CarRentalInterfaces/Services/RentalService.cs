using System;
using CarRentalInterfaces.Entities;

namespace CarRentalInterfaces.Services
{
    internal class RentalService
    {
        public double pricePerDay { get; set; }
        public double pricePerHour { get; set; }

        private BrazilTaxService _BrazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            this.pricePerDay = pricePerDay;
            this.pricePerHour = pricePerHour;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);

            double basicPayment = 0.0; 
            if (duration.TotalHours <= 12)
            {
                basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _BrazilTaxService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);
        }
    }
}
