using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    //Problem 6. Divisible by 7 and 3
    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

    class DivisibleTesting
    {
        static void Main()
        {
            List<int> coll = new List<int> { 1, 2, 3, 5, 7, 7, 876, 34, 34, 21 };

            Console.WriteLine("Extracting numbers with LAMBDA:");
            var div = coll.FindAll(x => x % 7 == 0 && x % 3 == 0).Select(x => x);
            foreach (var item in div)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Extracting numbers with LINQ:");
            var divLINQ =
                from numbers in coll
                where numbers % 7 == 0 && numbers % 3 == 0
                select numbers;
            foreach (var item in divLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
