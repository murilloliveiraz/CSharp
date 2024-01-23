using MulticastDelegates.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    internal class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
        }
    }
}
