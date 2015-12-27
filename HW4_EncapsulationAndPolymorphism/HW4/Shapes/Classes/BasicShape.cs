namespace Shapes.Classes
{
    using System;
    using Interfaces;

    public abstract class BasicShape : IShape
    {
        private double height;
        private double width;

        protected BasicShape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width", "can not be 0 or negative number");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height", "can not be 0 or negative number");
                }
                height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}