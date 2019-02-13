using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Animal : IAnimal
    {
        //auto-implemented properties
        public string Name { get; set; } = "No name";
        public string AnimalColor { get; set; } = "Color unknown";
        //only get  using properties
        public string SoundsOfAnimal { get; } = "No sound";

        //ctors
        public Animal(string name, string animalColor, string soundsOfAnimal) : this (name, animalColor)
        {
            SoundsOfAnimal = soundsOfAnimal;
        }
        public Animal(string name, string animalColor) : this(name)
        {
            AnimalColor = animalColor;
        }
        public Animal(string name) : this()
        {
            Name = name;
        }
        public Animal()
        {
        }

        //methods
        public virtual void Move() => Console.WriteLine("The animal cannot move");
        public void Voice()
        {
            if(SoundsOfAnimal != "No sound")
                Console.WriteLine($"{Name} make {SoundsOfAnimal.ToLower()} sound.");
            else
                Console.WriteLine("animals do not make sounds.");
        }
        public virtual void GetInfoAboutAnimal()
        {
            Console.WriteLine($"{Name.ToUpper()}:\nanimal color: {AnimalColor}");
            Move();
            Voice();
        }
    }
}
