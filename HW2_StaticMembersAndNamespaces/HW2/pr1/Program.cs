namespace pr1
{
    using System;
  
    class Program
    {
        static void Main()
        {
            
            //CREATE POINTS
            var firstPoint = new Point3D(11, 22, 13);
            var secondPoint = new Point3D(17, 6, 2.5);

            //PRINT POINTS
            Console.WriteLine("First point: " + firstPoint);
            Console.WriteLine("Second point: " + secondPoint);

            //PRINT START POINT
            Console.WriteLine("Start point: " + Point3D.StartPoint);

            
        }
    }
}
