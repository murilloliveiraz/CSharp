using System;

namespace InterfaceAndAbstract.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }

        public override string ToString()
        {
            return $"Circle, radius = {Radius}, color = {Color}, radius = {Area()}";
        }
    }
}
