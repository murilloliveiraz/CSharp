using System;
using CarRentalInterfaces.Entities;

namespace CarRentalInterfaces.Services
{
    internal class RentalService
    {
        public double pricePerDay { get; set; }
        public double pricePerHour { get; set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerDay = pricePerDay;
            this.pricePerHour = pricePerHour;
            this._taxService = taxService;
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
            double tax = _taxService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);
        }
    }
}
