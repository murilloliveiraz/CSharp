using Enumerator.Entities;
using Enumerator.Entities.Enums;

namespace Enumerator
{
    class Enumerator
    {
        static void Main(string[] args)
        {
            Order order = new Order 
            { 
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(OrderStatus.PendingPayment);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}