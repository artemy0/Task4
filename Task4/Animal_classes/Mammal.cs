using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Animal_classes
{
    class Mammal : Animal
    {
        public long Population { get; set; }

        public Mammal(string name, string animalColor, string soundsOfAnimal, long population) : base(name, animalColor, soundsOfAnimal)
        {
            Population = population;
        }
        public Mammal(string name, string animalColor, string soundsOfAnimal) : base(name, animalColor, soundsOfAnimal)
        {
        }

        public override void GetInfoAboutAnimal()
        {
            base.GetInfoAboutAnimal();
            Console.WriteLine($"population: {Population}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} can run");
        }
    }
}
