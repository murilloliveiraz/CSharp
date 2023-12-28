using System;
using System.Globalization;

namespace PooProduct
{
    internal class Product
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product() { }

        public string Nome
        {
            get { return _nome;  }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

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
            return _nome
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade
                + " unidades, Total $" 
                + totalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
