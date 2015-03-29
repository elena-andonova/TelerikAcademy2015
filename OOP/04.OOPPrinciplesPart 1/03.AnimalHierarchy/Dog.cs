using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, char sex)
            :base(name, age, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("I am a dog and I say WOOF!");
        }
    }
}
