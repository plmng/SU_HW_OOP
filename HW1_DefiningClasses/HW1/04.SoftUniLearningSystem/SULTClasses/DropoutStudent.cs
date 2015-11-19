namespace _04.SoftUniLearningSystem.SULTClasses
{
    using System;

    public class DropoutStudent : Student
    {
        //– field dropout reason, method Reapply() that prints all information about the student and the dropout reason
        public string DropoutReason { get; set; }

        public void Reapply()
        {
            Console.WriteLine("First name: {0}, Last name: {1}, Age: {2}\nStudent#: {3}, Average Grade: {4}\nDropoutReason: {5}", 
                FirstName, LastName, Age, StudentNumber, AverageGrade, DropoutReason);
        }
    }
}
