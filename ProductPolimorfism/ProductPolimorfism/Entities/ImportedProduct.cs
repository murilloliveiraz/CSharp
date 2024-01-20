using System;
using System.Globalization;

namespace ProductPolimorfism.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name}, R${Price.ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: R$ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
