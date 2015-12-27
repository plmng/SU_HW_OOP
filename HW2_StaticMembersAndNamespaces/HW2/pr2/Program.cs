namespace pr2
{
    using System;
    using pr1;

    class Program
    {
        static void Main()
        {
            //CREATE POINTS
            var p1 = new Point3D(-7, -4, 3);
            var p2 = new Point3D(17, 6, 2.5);

            //PRINT POINTS
            Console.WriteLine("First point: " + p1);
            Console.WriteLine("Second point: " + p2);

            //CALCULATE AND PRINT THE DISTANCE
            Console.WriteLine("Distance between points: ({0})", DistanceCalculator.CalculateDistance(p1, p2) );
        }
    }
}
