namespace _06.RemoveNumbers
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

            var query = sequence
                .GroupBy(n => n)
                .Where(g => g.Count() % 2 != 0)
                .Select(y => y.Key)                
                .ToList();

            Console.WriteLine("Removing all elements that occur odd number of times...");
            sequence.RemoveAll(el => query.Contains(el));            
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
