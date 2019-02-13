using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //The interface that will implement all classes of animals.
    public interface IAnimal
    {
        //properties
        string Name { get; set; }
        string AnimalColor { get; set; }
        string SoundsOfAnimal { get; }

        //methods
        void Voice();
        void Move();
    }
}
