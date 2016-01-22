namespace _07.NumberOccurrences
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
            Console.WriteLine("Number --> Occurrences");
            sequence
                .GroupBy(n => n)
                .Select(pair => new { Value = pair.Key, Counter = pair.Count() })
                .OrderBy(p => p.Value)
                .ToList()
                .ForEach(el => Console.WriteLine("    {0} --> {1}", el.Value, el.Counter));
        }
    }
}
