namespace _04.SoftUniLearningSystem.SULTClasses
{
    using System;

    public class SeniorTrainer: Trainer
    {
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been deleted", courseName);
        }
    }
}
