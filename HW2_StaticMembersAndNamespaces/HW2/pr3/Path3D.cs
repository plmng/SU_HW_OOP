namespace pr3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using pr1;

    public class Path3D
    {
        public Path3D(List<Point3D> pointsSequence)
        {
            this.PointsSequence = pointsSequence;
        }
        
        public List<Point3D> PointsSequence { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(String.Empty);
            var i = 1;

            foreach (var point in PointsSequence)
            {
                sb.AppendFormat("Point #{0}, Coordinates:{1}\n", i++, point);
            }
            return sb.ToString();
        }
    }
}
