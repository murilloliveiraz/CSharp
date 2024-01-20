using System;
using InterfaceAndAbstract.Model;
using InterfaceAndAbstract.Model.Entities;
using InterfaceAndAbstract.Model.Enums;

namespace InterfaceAndAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(){ Radius = 2.0 ,Color = Color.White};
            IShape retangle = new Retangle(){ Width = 20, Height = 10,Color = Color.White};
            Console.WriteLine(circle);
            Console.WriteLine(retangle);
        }
    }
}
