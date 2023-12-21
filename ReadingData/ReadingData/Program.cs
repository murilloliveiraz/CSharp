using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ReadingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("em qual periodo do dia estamos?");
            string period = Console.ReadLine();
            Console.WriteLine($"Boa(m) {period}");
            Console.WriteLine("Qual sua cor favorita?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine($"Sua cor favorita é {favoriteColor}");
            Console.WriteLine("Escreva suas 3 frutas favoritas:");
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine("suas frutas favoritas são: {0}, {1} e {2}", p1,p2, p3);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');  
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
