
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace OrderEnumExercise.Entities
{
    internal class OrderItem
    {
        Product product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, string name)
        {
            product = new Product(name, price);
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(product.Name);
            sb.Append(", R$");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: R$");
            sb.Append(subTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
