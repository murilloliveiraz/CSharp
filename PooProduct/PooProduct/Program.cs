using System;
using System.Globalization;

namespace PooProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço :");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto "+ p);

            Console.WriteLine();
            Console.WriteLine("digite o numero de produtos a ser adicionado");
            int qte = int.Parse(Console.ReadLine());
            p.addValueInStock(qte);

            Console.WriteLine("Dados do produto atualizados "+ p);

            Console.WriteLine();
            Console.WriteLine("digite o numero de produtos a ser removido");
            qte = int.Parse(Console.ReadLine());
            p.removeValueInStock(qte);

            Console.WriteLine("Dados do produto atualizados "+ p);

        }
    }
}
