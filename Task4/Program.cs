using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Animal_classes;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<Reptile> ReptileGroup = new Group<Reptile>(new Reptile[] { new Reptile("snake", "green", "hiss", true), new Reptile("turtle", "brown", "No voice", false) });
            //Other types of generic classes...
            Group<Animal> AllOfAnimalGroup = new Group<Animal>(new Fish("shark", "gray", "shaf"), new Bird("dove", "white/gray", "kurlyk"), new Mammal("tigers", "orange with black stripes/black with orange stripes", "roar", 45000),
                                             new Amphibian("frog", "green", "kva"), new Reptile("snake", "green", "hiss", true), new Reptile("turtle", "brown", "No voice", false));

            for (int i = 0; i < AllOfAnimalGroup.Length; i++)
            {
                AllOfAnimalGroup[i].GetInfoAboutAnimal();
                Console.WriteLine();
            }

            Console.ReadKey();    
        }
    }
}
