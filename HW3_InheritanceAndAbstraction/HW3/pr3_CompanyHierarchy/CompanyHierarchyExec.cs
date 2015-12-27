namespace pr3_CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Classes;

    class CompanyHierarchyExec
    {
        static void Main()
        {
           
            var salesEmployees = new List<Employee>()
            {
                new SalesEmployee(1, "SE1", "Georgiev", 1000m, new List<Sale>()
                {
                    new Sale("product1", new DateTime(2015, 11, 13), 10.00m ),
                    new Sale("product2", new DateTime(2015, 11, 14), 11m ),
                    new Sale("product3", DateTime.Now, 20.00m )
                }),
                new SalesEmployee(2, "SE2", "Petrov", 1000m, new List<Sale>()
                {
                    new Sale("product1", new DateTime(2015, 11, 11), 10.00m ),
                    new Sale("product2", new DateTime(2015, 11, 12), 11m ),
                    new Sale("product3", DateTime.Now, 20.00m )
                }),
                new SalesEmployee(3, "SE3", "Nedev", 1000m, new List<Sale>()
                {
                    new Sale("product1", new DateTime(2015, 11, 12), 10.00m ),
                    new Sale("product2", new DateTime(2015, 11, 11), 10.00m ),
                    new Sale("product3", DateTime.Now, 20.00m )
                }),
            };
            var developers = new List<Employee>()
            {
                new Developer(1, "dev", "Georgiev", 10000m, new List<Project>()
                {
                    new Project("C# project", new DateTime(2015, 10, 10), "RPG Game on C#"),
                    new Project("Java project", new DateTime(2015, 11, 10), "RPG Game on Java"),
                }),
                new Developer(2, "dev", "Georgiev", 10000m,  new List<Project>()
                {
                    new Project("C# project", new DateTime(2015, 10, 10), "RPG Game on C#"),
                    new Project("Java project", new DateTime(2015, 11, 10), "RPG Game on Java"),
                }),
                new Developer(3, "dev", "Georgiev", 10000m,  new List<Project>()
                {
                    new Project("C# project", new DateTime(2015, 10, 10), "RPG Game on C#"),
                    new Project("Java project", new DateTime(2015, 11, 10), "RPG Game on Java"),
                }),
            };
            var managers = new List<Employee>()
            {
                new Manager(1, "Parlina", "Pawlowa", 30000m, Department.Accounting, null), 
                new Manager(2, "Georgi", "Georgiev", 25000m, Department.Sales, salesEmployees ), 
                new Manager(3, "Nikola", "NIkolov", 35000m, Department.Production, developers),
            };

            List<Employee> employees = salesEmployees.Union(developers).Union(managers).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
