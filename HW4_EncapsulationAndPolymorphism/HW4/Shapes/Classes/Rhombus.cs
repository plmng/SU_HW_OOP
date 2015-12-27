﻿namespace Shapes.Classes
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
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
            var perimeter = 4*(Width);
            return perimeter;
        }
    }
}