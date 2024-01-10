using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPolimorfism.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"{Name}, R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
