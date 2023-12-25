using System;
using System.Globalization;

namespace PooAdvancedExercises
{
    internal class Retangle
    {

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Area = " 
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Perimetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                + "\n Diagonal = " 
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
