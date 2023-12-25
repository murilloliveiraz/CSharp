using System;
using System.Globalization;

namespace PooAdvancedExercises
{
    internal class Employee
    {
        public string Nome; 
        public double TotalSalary; 
        public double Taxes;
        
        public double liquidSalary()
        {
            return TotalSalary - Taxes;
        }
        public void SalaryIncrease(double percent)
        {
           TotalSalary += (TotalSalary * percent) / 100;
        }

        public override string ToString()
        {
            return  $"{Nome}, ${liquidSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
