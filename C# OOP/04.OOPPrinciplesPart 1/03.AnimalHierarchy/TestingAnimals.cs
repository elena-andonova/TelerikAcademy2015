using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
    //All animals can produce sound (specified by the ISound interface). 
    //Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
    //Each animal produces a specific sound.
    //Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
    class TestingAnimals
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
                                {
                                    new Dog("Fred", 5, 'M'),
                                    new Dog("Lasi", 6, 'F')
                                };
            Frog[] frogs = new Frog[] 
                                    {
                                        new Frog("jabcho", 2, 'M'),
                                        new Frog("jaba", 1, 'F'),
                                        new Frog("jabok", 4, 'M')
                                    };
            Cat[] cats = new Cat[]
                                {
                                    new Kitten("Mila", 5),
                                    new Tomcat("Kotak", 6),
                                    new Tomcat("Minikote", 1)
                                };
            Console.WriteLine("Dogs average age: {0:F2}", Animal.CalcAverageAge(dogs));
            Console.WriteLine("Frogs average age: {0:F2}", Animal.CalcAverageAge(frogs));
            Console.WriteLine("Cats average age: {0:F2}", Animal.CalcAverageAge(cats));
        }
    }
}
