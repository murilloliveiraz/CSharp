using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== EX 1 ==========");
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) Console.WriteLine("Pessoa mais velha é "+ p1.nome);
            if (p1.idade < p2.idade) Console.WriteLine("Pessoa mais velha é "+ p2.nome);

            Console.WriteLine("========== EX 2 ==========");
            Salario s1, s2;
            s1 = new Salario();
            s2 = new Salario();

            Console.WriteLine("Dados da primeira pessoa");
            s1.nome = Console.ReadLine();
            s1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa");
            s2.nome = Console.ReadLine();
            s2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("a media salarial é de " +(s1.salario + s2.salario) / 2);
        }
    }
}
