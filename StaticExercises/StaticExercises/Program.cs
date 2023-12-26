using System;
using System.Globalization;

namespace StaticExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolares;
            Console.WriteLine("Qual é a cotação do dólar");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares voce vai comprar");
            dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("o valor a ser pago é de " + ConversorDeMoeda.value(dolares, cotacao));
        }
    }
}
