using System;
using System.Globalization;

namespace ProductPolimorfism.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{Name}(used), R${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
