using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t11 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t11);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan t111 = TimeSpan.FromDays(1.5);
            TimeSpan t22 = TimeSpan.FromHours(1.5);
            TimeSpan t33 = TimeSpan.FromMinutes(1.5);
            TimeSpan t44 = TimeSpan.FromSeconds(1.5);
            TimeSpan t55 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t111);
            Console.WriteLine(t22);
            Console.WriteLine(t33);
            Console.WriteLine(t44);
            Console.WriteLine(t55);
            Console.WriteLine(t6);
        }
    }
}
