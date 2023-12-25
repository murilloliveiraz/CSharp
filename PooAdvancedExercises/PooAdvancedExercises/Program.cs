using System;
using System.Globalization;

namespace PooAdvancedExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== EX 1 =======");
            Retangle retangulo = new Retangle();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(retangulo);

            Console.WriteLine("====== EX 2 =======");
            Employee employee = new Employee();
            Console.WriteLine("Nome");
            employee.Nome = Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            employee.TotalSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto : ");
            employee.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionario: " + employee);

            Console.WriteLine("Digite a  porcentagem para aumentar o salario:");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.SalaryIncrease(percent);

            Console.WriteLine($"Dados atualizados do Funcionario: " + employee);

            Console.WriteLine("========== EX3 =========");
            SchoolGrades schoolGrades = new SchoolGrades();
            Console.WriteLine("Digite as tres notas do aluno: ");
            schoolGrades.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            schoolGrades.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            schoolGrades.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(schoolGrades);
        }
    }
}
