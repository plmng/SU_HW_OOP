namespace Shapes
{
    using System;
    using Classes;
    using Interfaces;

    public class ShapesExec
    {
        private static void Main()
        {
            var shapes = new IShape[]
            {
                new Circle(2),
                new Rectangle(2, 4),
                new Rhombus(3, 4),
                new Circle(6),
                new Rectangle(12, 4),
                new Rhombus(3, 14)
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}: Area: {1:N2}, Perimeter:{2:N2}",
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}