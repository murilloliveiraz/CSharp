using System;
using ShapeAbstract.Entities.Enums;

namespace ShapeAbstract.Entities
{
    internal class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(Colors color, double height, double width) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
