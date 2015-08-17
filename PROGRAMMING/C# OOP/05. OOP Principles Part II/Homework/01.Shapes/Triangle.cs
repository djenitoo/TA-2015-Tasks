namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (base.Height * base.Width) / 2;
        }
    }
}
