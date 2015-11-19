namespace _04.SoftUniLearningSystem.SULTClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return  string.Format("First name: {0}, Last name: {1}, Age: {2}", FirstName, LastName, Age);
        }
    }

}
