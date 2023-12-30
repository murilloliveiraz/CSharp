using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimespanFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine();
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan t11 = new TimeSpan(1, 30, 10);
            TimeSpan t22 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t11.Add(t2);
            TimeSpan dif = t11.Subtract(t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);

            TimeSpan t111 = new TimeSpan(1, 30, 10);
            TimeSpan t222 = new TimeSpan(0, 10, 5);

            Console.WriteLine(t111);
            TimeSpan mult = t111.Multiply(2.0);
            Console.WriteLine(mult);

            Console.WriteLine(t222);
            TimeSpan div = t222.Divide(2.0);
            Console.WriteLine(div);

        }
    }
}
