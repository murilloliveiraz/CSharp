using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise.Entities
{
    internal class Employee
    {
        public string name { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{name}, {email}, {salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Employee)) return false;
            Employee other = obj as Employee;
            return email.Equals(other.email);
        }

        public override int GetHashCode()
        {
            return email.GetHashCode();
        }
    }
}
