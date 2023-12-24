using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== EX 1 ==========");
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("=========== EX 2 ==========");
            int i, inaArray =  0, outArray = 0;
            i = int.Parse(Console.ReadLine());
            for (int index = 0; index < i; index++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp >= 10 && temp <= 20)
                {
                    inaArray++;
                } else
                {
                    outArray++;
                }
            }
            Console.WriteLine($"in {inaArray}");
            Console.WriteLine($"out {outArray}");

            Console.WriteLine("=========== EX 3 ==========");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("=========== EX 4 ==========");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                if(n1 != 0 && n2 != 0)
                {
                    double media = n1 / n2;
                    Console.WriteLine(media);
                } else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }

            Console.WriteLine("=========== EX 5 ==========");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);

            Console.WriteLine("=========== EX 6 ==========");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("=========== EX 5 ==========");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");

            }
        }
    }
}
