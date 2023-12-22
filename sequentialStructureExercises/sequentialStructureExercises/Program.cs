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

            Console.WriteLine("========== CALXULAODRA DE AREA DO Produto de 2 multiplicacoes ==========");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int result = a * b - c * d;
            Console.WriteLine("a diferenca do produto de n1 e n2 para n3 e n4 é de: "+ result);

            Console.WriteLine("========== CALXULAODRA DE SALARIO ==========");
            int functionaryNumber = int.Parse(Console.ReadLine());
            int hoursWorked = int.Parse(Console.ReadLine());
            double hourWorkedValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = hoursWorked * hourWorkedValue;
            Console.WriteLine($"o funcionario numero {functionaryNumber} recebe como salario R${salary.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("========== CAIXA DA LOJA ==========");
            Console.WriteLine("escreva o cidgo da peça, o numero de peças e o valor unitario separados por espacos");
            string[] vet1 = Console.ReadLine().Split(' ');
            Console.WriteLine("escreva o cidgo da peça, o numero de peças e o valor unitario separados por espacos");
            string[] vet2 = Console.ReadLine().Split(' ');
            int quantidade1 = int.Parse(vet1[1]);
            int quantidade2 = int.Parse(vet2[1]);
            double value1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double value2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double total = quantidade1 * value1 + quantidade2 * value2;
            Console.WriteLine("a compra 1 deu:" + total.ToString("F2", CultureInfo.InvariantCulture));

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
