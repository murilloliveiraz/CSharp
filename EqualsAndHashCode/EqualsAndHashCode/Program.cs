using EqualsAndHashCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAndHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLient a = new CLient { Name = "Maria", Email = "maria@gmail.com"};
            CLient b = new CLient { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
