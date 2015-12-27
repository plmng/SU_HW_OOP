namespace pr2
{
    using System;
    using pr1;

    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            double deltaX = (p2.X - p1.X) * (p2.X - p1.X),
                   deltaY = (p2.Y - p1.Y) * (p2.Y - p1.Y),
                   deltaZ = (p2.Z - p1.Z) * (p2.Z - p1.Z);
            return Math.Sqrt(deltaX + deltaY + deltaZ);
        }
    }
}
