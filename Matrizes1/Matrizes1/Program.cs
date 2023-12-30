using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
