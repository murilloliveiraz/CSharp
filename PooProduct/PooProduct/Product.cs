using System;
using System.Globalization;

namespace PooProduct
{
    internal class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double totalValueInStock()
        {
            return Preco * Quantidade;
        }

        public void addValueInStock(int qte)
        {
            Quantidade += qte;
        }

        public void removeValueInStock(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return Nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " unidades, Total $" 
                + totalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
