using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
