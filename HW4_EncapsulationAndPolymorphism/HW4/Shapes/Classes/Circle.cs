namespace Shapes.Classes
{
    using System;
    using Interfaces;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius", "can not be <= 0");
                }
                this.radius = value;

            }
        }

        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*Radius;
        }
    }
}