using System;
using System.Globalization;

namespace PooProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço :");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product(nome, preco);

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
