﻿using System;
using System.Globalization;

namespace ListEmployees
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id; 
            Name = name;
            Salary = salary;
        }

        public void increaseSalary( double percent)
        {
            this.Salary += (this.Salary * percent / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
