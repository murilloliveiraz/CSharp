using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int minimumAge = 18;
            int maximumAge = 80;
            Console.WriteLine("Informe sua idade:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age >= minimumAge && age <=maximumAge) {
                Console.WriteLine("Liberado para dirigir meu patrao");
            } else { Console.WriteLine("Sem liberação para conduzir");}
            Console.ReadLine();
        }
    }
}
