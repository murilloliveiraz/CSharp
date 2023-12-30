using System;
using System.Globalization;

namespace DateTimeAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d11 = DateTime.Now;
            DateTime d22 = DateTime.UtcNow;
            DateTime d33 = DateTime.Today;
            Console.WriteLine(d11);
            Console.WriteLine(d22);
            Console.WriteLine(d33);

            DateTime d111 = DateTime.Parse("2000-08-15");
            DateTime d222 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d333 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d111);
            Console.WriteLine(d222);
            Console.WriteLine(d333);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}
