using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mercedes";
            float speed = 154.87f;
            int carNumber = 10;
            bool racingCar = true;
            dynamic carColor = "Vermelho";
            const float pi = 3.141516f;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(pi);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(carName);
            Console.WriteLine(carNumber);
            Console.WriteLine(speed);
            Console.WriteLine(racingCar);
            Console.WriteLine(carColor);
            
            double saldo = 10.35784;
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
