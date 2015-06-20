using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    abstract class Cat : Animal, ISound
    {
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("I am a cat and I say MEOWWWW!");
        }
    }
}
