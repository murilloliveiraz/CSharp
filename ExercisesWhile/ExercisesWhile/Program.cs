using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 2002;
            Console.WriteLine("Digite a senha");
            int tryedPassword = int.Parse(Console.ReadLine());
            while ( tryedPassword != password)
            {
                Console.WriteLine("Senha incorreta");
                Console.WriteLine("Digite a senha:");
                tryedPassword = int.Parse(Console.ReadLine());
            }
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {
                Console.WriteLine(check(x, y));
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("acabou");
            Console.WriteLine("1. Alcool  \n 2.Gasolina \n 3.Diesel \n 4.Fim");
            int preference = int.Parse(Console.ReadLine());
            int alcool= 0, gasolina = 0, diesel = 0;

            while (preference != 4) {
                if (preference == 1)
                {
                    alcool++;
                }
                else if (preference == 2)
                {
                    gasolina++;
                }
                else if (preference == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Informe um codigo valido");
                }
                Console.WriteLine("1. Alcool  \n 2.Gasolina \n 3.Diesel \n 4.Fim");
                preference = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool :{alcool} \n Gasolina: {gasolina} \n Diesel: {diesel} \n");
        }

        static string check(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return "primeiro";
            }
            else if (x < 0 && y < 0)
            {
                return "terceiro";
            }
            else if (x < 0 && y > 0)
            {
                return "segundo";
            }
            else
            {
                return "quarto";
            }

        }
    }
}
