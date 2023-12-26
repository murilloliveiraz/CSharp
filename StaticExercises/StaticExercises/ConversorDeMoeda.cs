using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercises
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.00;

        public static double value(double dolar, double cotacao)
        {
            return dolar * cotacao + (dolar * cotacao * iof / 100);
        }
    }
}
