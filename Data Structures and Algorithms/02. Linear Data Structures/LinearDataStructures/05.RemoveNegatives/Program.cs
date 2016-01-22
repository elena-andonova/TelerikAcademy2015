namespace _05.RemoveNegatives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of number divided by comma and space(e.g.: 2, 3, 4)...");
            //var sequence = new List<int> { 1, 3, 4, -2, 4, -3, 5 };
            var sequence = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            Console.WriteLine("Removing all negative numbers");            
            sequence.RemoveAll(n => n < 0);
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
