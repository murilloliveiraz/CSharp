using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooAdvancedExercises
{
    internal class SchoolGrades
    {
        public double Grade1;
        public double Grade2;
        public double Grade3;
        public double total;

        public double TotalGrade()
        {
            return total = Grade1 + Grade2 + Grade3;
        }

        public string Situation()
        {
            if(total <= 60.0)
            {
                return $"Reprovado  \n Faltaram {total - 60} pontos";
            } else
            {
                return "Aprovado";
            }
        }

        public override string ToString()
        {
            return $"Nota final: {TotalGrade()} \n {Situation()}";
        }
    }
}
