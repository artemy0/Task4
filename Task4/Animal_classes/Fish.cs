using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Animal_classes
{
    class Fish : Animal
    {
        public Fish(string name, string animalColor, string soundsOfAnimal) : base(name, animalColor, soundsOfAnimal)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} can swim");
        }
    }
}
