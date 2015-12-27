namespace pr3
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using pr1;

    public class Storage
    {
        public static void SavePath(Path3D path, string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine(path);
            }
        }

        public static Path3D LoadPath(string fileName)
        {
            var path = new Path3D(new List<Point3D>());

            using (var reader = new StreamReader(fileName))
            {
                var line = reader.ReadLine();

                const string pattern = "Point #[0-9]+, Coordinates:{ (-?[0-9]+\\.?[0-9]*), (-?[0-9]+\\.?[0-9]*), (-?[0-9]+\\.?[0-9]*) }";
      
                while (line != null)
                {
                    if (line != "")
                    {
                        var matches = Regex.Matches(line, pattern);

                        if (matches[0].Groups.Count == 4)
                        {
                            var x = double.Parse(matches[0].Groups[1].Value);
                            var y = double.Parse(matches[0].Groups[2].Value);
                            var z = double.Parse(matches[0].Groups[3].Value);
                            var point = new Point3D(x, y, z);
                            path.PointsSequence.Add(point);
                        }
                    }

                    line = reader.ReadLine();
                }
            }
            return path; 
        }
    }
}
