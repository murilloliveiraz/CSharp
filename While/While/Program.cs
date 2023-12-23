using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double x = double.Parse(Console.ReadLine());

            while (x > 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um outro numero");
                x = double.Parse(Console.ReadLine());
            }
        }
    }
}
