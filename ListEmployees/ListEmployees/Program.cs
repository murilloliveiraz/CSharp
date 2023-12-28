using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Salary :");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int increaseId = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee employeeWithIncreasedSalary = list.Find(x => x.Id == increaseId);
            if(employeeWithIncreasedSalary != null)
            {
                employeeWithIncreasedSalary.increaseSalary(percent);
            } else
            {
                Console.WriteLine("This id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
