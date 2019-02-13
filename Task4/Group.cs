using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Group<T> where T : Animal
    {
        private T[] Animals;
        public int Length { get { return Animals.Length; } }

        public Group(params T[] animals)
        {
            Animals = animals;
        }

        //or IComparable interface implementation
        public T this[int index]
        {
            get
            {
                return Animals[index];
            }
            set
            {
                Animals[index] = value;
            }
        }
    }
}
