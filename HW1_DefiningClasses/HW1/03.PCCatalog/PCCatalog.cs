using System;
using System.Collections.Generic;

class PCComponents
{
    static void Main()
    {
        List<Computer> listComputers = new List<Computer>()
        {new Computer("Lenovo", new List<Component>(){new Component("Lenovo", 200, "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)"), new Component("RAM", 12400.01)}),
         new Computer("HP", new List<Component>() { new Component("processor", 400.02), new Component("RAM", 300.02), new Component("graphics card", 400.45, "details....") })};

        listComputers.Sort((x, y) => x.Price.CompareTo(y.Price));
        foreach (var computer in listComputers)
        {
            Console.WriteLine(computer + "\n");
        }
    }
}

