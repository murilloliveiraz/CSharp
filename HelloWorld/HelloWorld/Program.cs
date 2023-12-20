using System;
using System.Collections.Generic;
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

            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World 2");
            Console.WriteLine(carName);
            Console.WriteLine(carNumber);
            Console.WriteLine(speed);
            Console.WriteLine(racingCar);
            Console.WriteLine(carColor);
            Console.ReadLine();
        }
    }
}
