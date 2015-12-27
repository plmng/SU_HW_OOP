namespace pr2_Animals
{
    using System;

    public class Frog: Animal
    {
        public Frog(string name, Gender gender, int age) : base(name, gender, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("croak");
        }
    }
}
