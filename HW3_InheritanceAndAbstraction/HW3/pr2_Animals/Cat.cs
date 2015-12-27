namespace pr2_Animals
{
    using System;

    public abstract class Cat: Animal
    {
        protected Cat(string name, Gender gender, int age) : base(name, gender, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miao");
        }
    }
}
