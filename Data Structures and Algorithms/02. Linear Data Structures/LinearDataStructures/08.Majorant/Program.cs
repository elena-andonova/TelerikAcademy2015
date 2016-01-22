namespace _08.Majorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sequence of number divided by comma and space(e.g.: 2, 3, 4)...");
            //var sequence = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var sequence = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            var majorantOccurencesMin = (sequence.Count / 2) + 1;
            var majorant = sequence
                    .GroupBy(n => n)
                    .Where(g => g.Count() >= majorantOccurencesMin)
                    .Select(pair => new { Value = pair.Key, Counter = pair.Count() })
                    .OrderBy(p => p.Value)
                    .ToList()
                    .FirstOrDefault();

            if (majorant != null)
            {
                Console.WriteLine("The Majorant is {0} and occurs {1} times", majorant.Value, majorant.Counter);
            }
            else
            {
                Console.WriteLine("There is no Majorant!");
            }            
        }
    }
}
