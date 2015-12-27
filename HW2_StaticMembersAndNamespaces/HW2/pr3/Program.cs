namespace pr3
{
    using System;
    using System.Collections.Generic;
    using pr1;

    class Program
    {
        static void Main()
        {
            //CREATE PATH
            var path1 = new Path3D(new List<Point3D>()
            {
                new Point3D(1, 2, 3),
                new Point3D(2, 4, 5),
                new Point3D(-12, 2.2, 1),
                new Point3D(-2.1, 0, -1.5)
            });

            //SET FILE PATH
            const string file = "../../path1.txt";
            
            //EXECUTE SAVE PATH FROM STORAGE CLASS
            Storage.SavePath(path1, file);
            
            //EXECUTE LOAD PATH FROM STORAGE CALSS
            var loadedPath = Storage.LoadPath(file);

            //PRINT LOADED PATH
            Console.WriteLine(loadedPath);
        }
    }
}
