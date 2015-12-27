namespace pr1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 12, 23, 65, 4, 1, 2 };
            list
                .WhereNot(e => e % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine(list.Maximum(i => i));
        }
    }
}
