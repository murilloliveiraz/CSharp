using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using LinqExercise.Entities;
using System.Linq;

namespace LinqExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Employee> set = new HashSet<Employee>();
            Console.WriteLine("Enter the file full path:");
            string path = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double consultSalary = double.Parse(Console.ReadLine());
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        set.Add(new Employee(name, email, salary));
                    }
                }
                var emails = set.Where(emp => emp.salary >= consultSalary).OrderBy(emp => emp.salary);
                var sum = set.Where(emp => emp.name[0] == 'M').Sum(emp => emp.salary);
                foreach (Employee emp in emails)
                {
                    Console.WriteLine(emp.email);
                }
                Console.WriteLine("Sum of salary of people whose name starts with 'M':" + sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

