namespace pr2_Animals
{
    using System;

    public class Dog: Animal
    {
        public Dog(string name, Gender gender, int age) : base(name, gender, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
