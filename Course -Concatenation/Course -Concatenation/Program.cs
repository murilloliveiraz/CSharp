using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course__Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade2 = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0} cujo preço é ${1}", produto1, preco1);
            Console.WriteLine("{0} cujo preço é ${1}", produto2, preco2);
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}");
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F3}");
            Console.WriteLine($"Medida com 8 casas decimais:" + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
