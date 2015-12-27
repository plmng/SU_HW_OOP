namespace pr1_HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanStudentWorkerExec
    {
        static void Main()
        {
            //•	Initialize a list of 10 students and sort them by faculty number in ascending order (use a LINQ query or the OrderBy() extension method). Initialize a list of 10 workers and sort them by payment per hour in descending order. 
            //•	Merge the lists and then sort them by first name and last name.

            var students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "123we456sd"),
                new Student("Ivana", "Ivanova", "123we456"),
                new Student("Dragan", "Draganchov", "3we456sd"),
                new Student("Draganka", "Draganchova", "43we456sd"),
                new Student("Alex", "Ivanov", "9876jkm08d"),
                new Student("Straxil", "Staxov", "234sgt541"),
                new Student("Maria", "Draganchov", "8764sdrf9a"),
                new Student("Miroslav", "Mihailov", "673omn982r"),
                new Student("Marina", "Mihova", "5we456sd"),
                new Student("Pavlina", "Georgieva", "0483we456s")
            };

            students = students.OrderBy(s => s.FacultyNumber).ToList();

            var workers = new List<Worker>()
            {
                new Worker("wfn1", "wln1", 4500m, 8),
                new Worker("wfn2", "wln2", 400m, 8),
                new Worker("wfn3", "wln3", 5500m, 8),
                new Worker("wfn4", "wln4", 500m, 8),
                new Worker("wfn5", "wln5", 6500m, 8),
                new Worker("wfn6", "wln6", 700m, 8),
                new Worker("wfn7", "wln7", 100m, 8),
                new Worker("wfn8", "wln8", 4600m, 8),
                new Worker("wfn9", "wln9", 1500m, 8),
                new Worker("wfn10", "wln10", 300m, 8),
            };

            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            List<Human> humans = students.Union<Human>(workers)
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName)
                .ToList();

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }

        }
    }
}
