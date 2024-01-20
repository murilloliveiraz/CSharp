namespace InterfaceAndAbstract.Model.Entities
{
    internal class Retangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Circle, height = {Height}, width = {Width}, color = {Color}, area = {Area()}";
        }
    }
}
