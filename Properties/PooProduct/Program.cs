using System;
using System.Globalization;

namespace PooProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Tv", 900.00, 10);
            Console.WriteLine(p.Nome);
            p.Nome= "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
