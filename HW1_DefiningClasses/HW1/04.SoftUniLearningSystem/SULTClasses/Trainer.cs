namespace _04.SoftUniLearningSystem.SULTClasses
{
    using System;

    public class Trainer : Person
    {
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been crated", courseName);
        }

    }
}
