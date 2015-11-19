namespace _04.SoftUniLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    using SULTClasses;

    class SULSTest
    {
        static void Main(string[] args)
        {

           var fullObjCollection = CreateObjectsList();
           var currentStudents = fullObjCollection
                .Where(a => a is CurrentStudent).Cast<CurrentStudent>().ToList()
                .OrderBy(cs => cs.AverageGrade).ToList();

            Console.WriteLine("List of current students (sorted by average grade):");
            Console.WriteLine("===================================================\n");
            foreach (var student in currentStudents)
            {
                Console.WriteLine(student + "\n");
            }

        }

        private static List<Person> CreateObjectsList()
        {
            return new List<Person>()
            {
                new JuniorTrainer()
                    {
                        FirstName = "Ivan",
                        LastName = "Ivanov",
                        Age = 26
                    },
                new SeniorTrainer()
                    {
                        FirstName = "Georgi",
                        LastName = "Georgiev",
                        Age = 27
                    },
                new GraduateStudent()
                    {
                        FirstName = "Dragancho",
                        LastName = "Dragabchev",
                        Age = 18,
                        AverageGrade = 5.85,
                        StudentNumber = "00043985"
                    },
               new DropoutStudent()
                    {
                        FirstName = "Pesho",
                        LastName = "Peshev",
                        Age = 15,
                        AverageGrade = 3.15,
                        DropoutReason = "untaken exams",
                        StudentNumber = "00043983"
                    },
                new OnlineStudent()
                    {
                        FirstName = "Svetlin",
                        LastName = "Dimitrov",
                        Age = 18,
                        AverageGrade = 5.85,
                        StudentNumber = "00043934",
                        CurrentCourse = "OOP"
                    },
                new OnsideStudent()
                    {
                        FirstName = "Pavlina",
                        LastName = "Petrova",
                        Age = 18,
                        AverageGrade = 5.85,
                        StudentNumber = "00043987",
                        CurrentCourse = "OOP",
                        NumberOfVisits = 6
                    },

                new Person()
                    {
                        FirstName = "Ivancho",
                        LastName = "Ivanchev",
                        Age = 20
                    },
                new Student()
                    {
                        FirstName = "Mariika",
                        LastName = "Petkova",
                        Age = 22,
                        AverageGrade = 4.22,
                        StudentNumber = "0098762"
                    },
                new Trainer()
                    {
                        FirstName = "Chuck",
                        LastName = "Noris",
                        Age = 60
                    },
                 new CurrentStudent()
                    {
                        FirstName = "Dian",
                        LastName = "Dobrev",
                        Age = 26,
                        AverageGrade = 5.20,
                        CurrentCourse = "OOP",
                        StudentNumber = "009987654"
                    },
                 new OnlineStudent()
                    {
                        FirstName = "Penka",
                        LastName = "Maiakovska",
                        Age = 20,
                        AverageGrade = 5.75,
                        StudentNumber = "00043977",
                        CurrentCourse = "OOP"
                    },
                new OnsideStudent()
                    {
                        FirstName = "Tatiana",
                        LastName = "Dencheva",
                        Age = 21,
                        AverageGrade = 5.65,
                        StudentNumber = "00043537",
                        CurrentCourse = "OOP",
                        NumberOfVisits = 6
                    }
            };
        }
    }
}
