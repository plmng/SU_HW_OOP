namespace Pr3
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<StringDisperser> strings = new List<StringDisperser>()
            {
                new StringDisperser("dragancho", "graganchev"),
                new StringDisperser("petkancho", "petkanchev")
            };
            Console.WriteLine("dispensers");
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("check foreach on first dispenser");
            foreach (var symbol in strings[0])
            {
                Console.WriteLine(symbol);
            }
            Console.WriteLine("check equals with equals(), this != and with ==");
            Console.WriteLine(strings[0].Equals(strings[1]));
            Console.WriteLine(strings[0]!=(strings[1]));
            Console.WriteLine(strings[0] == (strings[1]));

            Console.WriteLine("clone");
            strings.Add((StringDisperser)strings[0].Clone());
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
            
        }
    }
}
