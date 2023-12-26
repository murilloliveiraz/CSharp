using System;
using System.Globalization;

namespace PooProduct
{
    internal class Product
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Product() { }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1) 
            {
                _nome = nome;
            }
        }
        public double GetPreco() { 
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double totalValueInStock()
        {
            return _preco * _quantidade;
        }

        public void addValueInStock(int qte)
        {
            _quantidade += qte;
        }

        public void removeValueInStock(int qte)
        {
            _quantidade -= qte;
        }

        public override string ToString()
        {
            return _nome
                + ", $" 
                + _preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + _quantidade
                + " unidades, Total $" 
                + totalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
