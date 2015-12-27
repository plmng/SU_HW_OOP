namespace Shapes.Classes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            var area = Height*Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2*(Height + Width);
            return perimeter;
        }
    }
}