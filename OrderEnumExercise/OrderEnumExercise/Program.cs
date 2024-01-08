using OrderEnumExercise.Entities;
using System;
using System.Globalization;

namespace OrderEnumExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name : ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(Name, Email, BirthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: "); 
            string stts = Console.ReadLine();
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), stts, true);
            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, name);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
