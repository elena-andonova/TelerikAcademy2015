using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extensions
{
    class ExtensionsTests
    {
        static void Main()
        {
            Console.WriteLine("Substring Extension Method Test");
            Console.WriteLine(new string('-', 35));
            StringBuilder testInStr = new StringBuilder("Homework");
            StringBuilder testSubstring = testInStr.Substring(4, 4);
            Console.WriteLine("Substring: " + testSubstring);       //work
            Console.WriteLine();
            

            Console.WriteLine("IEnumerable Extension Methods Test");
            Console.WriteLine(new string('-', 35));
            List<int> coll = new List<int> { 1, 2, 3, 5, 7, 7, 876, 34, 34 };
            Console.WriteLine("Sum: " + coll.Sum());                //969
            Console.WriteLine("Product: " + coll.Product());        //1 488 604 320
            Console.WriteLine("Min: " + coll.Min());                //1
            Console.WriteLine("Max: " + coll.Max());                //876
            Console.WriteLine("Average: " + coll.Average());        //107
            Console.WriteLine();
        }
    }
}
