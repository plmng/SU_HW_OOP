namespace pr1
{
    using System;


    public class Point3D
    {
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);

        public Point3D( double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPoint
        {
            get { return startPoint; }
        }

        public override string ToString()
        {
            return String.Format("{{ {0}, {1}, {2} }}", this.X, this.Y, this.Z);
        }

    }
}
