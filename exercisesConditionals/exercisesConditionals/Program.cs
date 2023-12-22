using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace exercisesConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== EX 1 ==========");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Positivo");
            }

            Console.WriteLine("========== EX 2 ==========");
            int n1;
            n1 = int.Parse(Console.ReadLine());
            if (n1%2 == 0)
            {
                Console.WriteLine("Par");
            } else
            {
                Console.WriteLine("impar");
            }

            Console.WriteLine("========== EX 3 ==========");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("multiplos");
            }else
            {
                Console.WriteLine("nao sao multiplos");
            }

            Console.WriteLine("========== EX 3 ==========");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int total;
            if(start > end)
            {
                total = 24 - start + end;
            } else
            {
                total = end - start;
            }
            Console.WriteLine("O JOGO DUROU "+ total);
            
            Console.WriteLine("========== EX 4 ==========");
            int cod, quant;
            double total = 0.0;
            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            quant = int.Parse(vet[1]);
            if(cod == 1)
            {
                total = quant * 4.00;
            } else if (cod == 2) {
                total = quant * 4.50;
            } else if (cod == 3)
            {
                total = quant * 5.00;
            } else if (cod == 4)
            {
                total = quant * 2.0;
            } else if(cod == 5)
            {
                total = quant * 1.50;
            } else
            {
                total = 0;
            }
            Console.WriteLine("O total é de R$"+ total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("=========== EX 5 ==========");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(value >= 0 &&  value <= 25)
            {
                Console.WriteLine("[0,25");
            }else if (value >= 25 && value <= 50)
            {
                Console.WriteLine("[25, 50");
            }
            else if (value >= 50 && value <= 75)
            {
                Console.WriteLine("[50, 75");
            }
            else if (value >= 75 && value <= 100)
            {
                Console.WriteLine("[75, 100");
            } else
            {
                Console.WriteLine("valor nao esta entre 0 e 100");
            }

            Console.WriteLine("=========== EX 6 ==========");
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("eixo origem");
            }

            Console.WriteLine("========== EX 8 ===========");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;
            if (value <= 2000.00 )
            {
                imposto = 0;
                Console.WriteLine("Isento");
            }
            else if (value <= 3000.00 )
            {
                Console.WriteLine("8% de taxa");
                imposto = ((value - 2000) * 8) / 100;
                Console.WriteLine(imposto);
            }
            else if ( value <= 4500.00)
            {
                Console.WriteLine("18%");
                double eightPercent = (1000 * 8) / 100;
                value -= 3000;
                double eighteenPercent = (value * 18) / 100;
                imposto = eightPercent + eighteenPercent;
                Console.WriteLine(imposto);
            }
            else
            {
                Console.WriteLine("28%");
                double eightPercent = (1000 * 8) / 100;
                value -= 3000;
                double eighteenPercent = (1500 * 18) / 100;
                value -= 1500;
                double twentyEightPercent = (value * 28) / 100;
                imposto = eightPercent + eighteenPercent + twentyEightPercent;
                Console.WriteLine(imposto);
            }
        }
    }
}
