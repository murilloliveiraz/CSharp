using ProductPolimorfism.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPolimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<Product> Products = new List<Product>();
            
            for (int i = 1;i <= numberOfProducts;i++) 
            {
                Console.Write($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Product product = new Product(name, price);
                    Products.Add(product);

                } else if (resp == 'i') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    Product product = new ImportedProduct(name, price, customsFee);
                    Products.Add(product);
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, date);
                    Products.Add(product);
                }
            }

            foreach (Product product in Products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
