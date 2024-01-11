using Exceptions.Entities;
using Exceptions.Entities.Exception;
using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in Date(dd/mm/yyyy):");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date(dd/mm/yyyy):");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine(reservation);
                Console.Write("Enter data to update the reservation:");
                Console.Write("Check-in Date(dd/mm/yyyy):");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date(dd/mm/yyyy):");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainException ex) 
            {
                Console.WriteLine("Error in reservation: " + ex.Message);
            }
        }
    }
}
