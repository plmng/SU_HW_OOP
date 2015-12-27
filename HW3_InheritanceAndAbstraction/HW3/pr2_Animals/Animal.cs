namespace pr2_Animals
{
    public abstract class Animal:ISoundProducible
    {
        protected Animal(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public abstract void ProduceSound();

        public override string ToString()
        {
            var result = string.Format("{0}, Name:{1}, Gender: {2}, Age: {3}", this.GetType().Name, this.Name,
                this.Gender, this.Age);
            return result;
        }
    }
}
