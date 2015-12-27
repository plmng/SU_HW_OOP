namespace Problem3and4.GenericListandVersionAttribute
{
    using System;
    using System.Linq;

    class GenericListExec
    {
        static void Main()
        {
            var list = new GenericList<int> {10, 20, 30, 40};
            Console.WriteLine("List Capacity: " + list.Capacity);
            Console.WriteLine("List Count: " + list.Count);
            Console.WriteLine(list);
            Console.WriteLine();
            Console.WriteLine("Add element (50) to the list");
            list.Add(50);
            Console.WriteLine(list);
            Console.Write("get element on index 1: ");
            Console.WriteLine(list[1]);
            Console.WriteLine("remove element on index 1");
            list.Remove(1);
            Console.WriteLine(list);
            Console.WriteLine("Insert element (200) on index 1");
            list.Insert(200, 1);
            Console.WriteLine(list);
            Console.Write("finding element index by given value(200): ");
            Console.WriteLine(list.Find(200));
            Console.Write("finding element index by given value(500): ");
            Console.WriteLine(list.Find(500));
            Console.WriteLine();
            Console.Write("checking if the list contains a value(200): ");
            Console.WriteLine(list.Contain(200));
            Console.Write("checking if the list contains a value(500): ");
            Console.WriteLine(list.Contain(500));
            Console.WriteLine();
            Console.Write("find max number in list: ");
            Console.WriteLine(list.Max());
            Console.Write("find min number in list: ");
            Console.WriteLine(list.Min());
            Console.WriteLine();
            Console.WriteLine("Clear list");
            list.Clear();
            Console.WriteLine(list);
            Console.WriteLine("get Version Attribute of GenericList<T>: " + GetVersion());
            ;

        }

        private static string GetVersion()
        {
            Type type = typeof(GenericList<>);
            var str = string.Empty;
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);

            return allAttributes.Cast<VersionAttribute>().Aggregate(str, (current, attr) => current + String.Format("This class version is {0}.{1}\n", attr.Major, attr.Minor));
        }
    }
}
