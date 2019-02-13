using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Animal_classes
{
    public class Reptile : Animal
    {
        public bool IsPredators { get; set; }

        public Reptile(string name, string animalColor, string soundsOfAnimal, bool isPredator) : base(name, animalColor, soundsOfAnimal)
        {
            IsPredators = isPredator;
        }
        public Reptile(string name, string animalColor, string soundsOfAnimal) : base(name, animalColor, soundsOfAnimal)
        {
        }

        public override void GetInfoAboutAnimal()
        {
            base.GetInfoAboutAnimal();
            if (IsPredators)
                Console.WriteLine($"{Name} is predators");
            else
                Console.WriteLine($"{Name} isn't predators");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} can run, crawl, swim");
        }
    }
}
