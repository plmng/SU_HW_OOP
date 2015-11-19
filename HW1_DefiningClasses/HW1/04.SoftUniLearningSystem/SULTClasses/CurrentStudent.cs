namespace _04.SoftUniLearningSystem.SULTClasses
{
    public class CurrentStudent: Student
    {
        public string CurrentCourse { get; set; }
        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Age: {2}\nStudent#: {3}, Average Grade: {4},  Current course:{5}",
                FirstName, LastName, Age, StudentNumber, AverageGrade, CurrentCourse);
        }
    }
}
