using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuittionOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int a1 = 10;
            a1++;
            Console.WriteLine(a1);

            int a2 = 10;
            int b2 = a2++;
            Console.WriteLine(a2);
            Console.WriteLine(b2);

            int a3 = 10;
            int b3 = ++a3;
            Console.WriteLine(a3);
            Console.WriteLine(b3);
        }
    }
}
