namespace pr1_HumanStudentWorker
{
    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            var result = string.Format("{0} {1}", this.FirstName, this.LastName);
            return result;
        }
    }
}
