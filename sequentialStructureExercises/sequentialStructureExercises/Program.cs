using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sequentialStructureExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== CALCULAdORA DE SOMA =============");
            Console.WriteLine("escreva o numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva o n2:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é "+ (n1+n2));

            Console.WriteLine("========== CALXULAODRA DE AREA DO CIRCULO ==========");
            Console.WriteLine("informe o valor da circunferencia do circulo:");
            double circunference = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * circunference * circunference;
            Console.WriteLine("a area do circulo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
