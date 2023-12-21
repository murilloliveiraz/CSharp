using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAndCastingVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x =4.5f;
            double y = x;

            Console.WriteLine(x);

            double a;
            float b;

            a = 5.1;
            b =  (float)a;
            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            int n1 = 5;
            int n2 = 2;

            double result = (double)n1 / n2;

            Console.WriteLine(result);
        }
    }
}
