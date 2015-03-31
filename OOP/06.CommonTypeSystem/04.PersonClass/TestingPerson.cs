using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    class TestingPerson
    {
        static void Main()
        {
            Person testPerson1 = new Person("Ana", 5);
            Person testPerson2 = new Person("Kolyo", null);
            Console.WriteLine(testPerson1.ToString());            
            Console.WriteLine(testPerson2.ToString());
        }
    }
}
