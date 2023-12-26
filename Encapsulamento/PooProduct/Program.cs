using System;
using System.Globalization;

namespace PooProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Tv", 900.00, 10);
            Console.WriteLine(p.getNome());
            p.setNome("TV 4K");
            Console.WriteLine(p.getNome());
        }
    }
}
