namespace pr2_Animals
{
    using System;
    using System.Linq;

    class AnimalsExec
    {
        static void Main(string[] args)
        {
            /*
             * Create an array of different kinds of animals 
             * and calculate the average age of each kind of animal using LINQ.
             */


            var animals = new Animal[]
            {
                new Dog("Sharo", Gender.Male, 2), 
                new Dog("Rex", Gender.Male, 4), 
                new Dog("Biva",Gender.Female, 3), 
                new Frog("qua1", Gender.Male, 1), 
                new Frog("qua2", Gender.Female, 2), 
                new Frog("qua3", Gender.Male, 1), 
                new Kitten("Maca", 2), 
                new Kitten("Macurana", 3), 
                new Kitten("Macka", 1), 
                new Tomcat("Tom", 3),
                new Tomcat("Tomcho", 2), 
                new Tomcat("Tomcheto", 2), 
            };
            var avgAgeByGroupsOfAnimals = from animal in animals
                                 group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into gr
                                 select new
                                 {
                                     Group = gr.Key,
                                     AvrAge = gr.ToList().Average(a => a.Age)
                                 };
            foreach (var animalGroup in avgAgeByGroupsOfAnimals)
            {
                Console.WriteLine("GroupName: {0}, AvarageAge: {1:F2} ", animalGroup.Group, animalGroup.AvrAge);
            }
            Console.WriteLine();
            Console.WriteLine("Test classes:");
            var dogRex = animals.FirstOrDefault(a => a.Name == "Rex");
            Console.WriteLine(dogRex);
            dogRex.ProduceSound();

            Console.WriteLine();
            var frogQua1 = animals.First(a => a.Name == "qua1");
            Console.WriteLine(frogQua1);
            frogQua1.ProduceSound();

            Console.WriteLine();
            var maca = animals.First(a => a.Name == "Maca");
            Console.WriteLine(maca);
            maca.ProduceSound();

            Console.WriteLine();
            var tom = animals.First(a => a.Name == "Tom");
            Console.WriteLine(tom);
            tom.ProduceSound();

        }
    }
}
