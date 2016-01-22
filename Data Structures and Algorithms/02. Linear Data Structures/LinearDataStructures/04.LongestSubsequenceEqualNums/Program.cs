namespace _04.LongestSubsequenceEqualNums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your numbers...");

            var numbers = new List<int>();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                var number = int.Parse(line);
                numbers.Add(number);
            }

            var currentNumber = numbers[0];
            var currentCounter = 1;
            var maxCounter = 1;
            var maxNumber = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCounter++;
                }
                else
                {
                    currentNumber = numbers[i];
                    currentCounter = 1;
                }

                if (currentCounter > maxCounter)
                {
                    maxCounter = currentCounter;
                    maxNumber = currentNumber;
                }
            }

            Console.WriteLine("Finding the longest subsequence with equal numbers.. ");
            var longestSubsequenece = Enumerable.Repeat(maxNumber, maxCounter).ToList();
            Console.WriteLine(string.Join(", ", longestSubsequenece));
            Console.WriteLine();

            var query = numbers
                .GroupBy(n => n)
                .OrderByDescending(n => n.Count())
                .Select(n => new{ Number = n.Key,Counter = n.Count()})
                .First();

            Console.WriteLine("..and the same thing but with LINQ:");
            var longestSubsequeneceLinq = Enumerable.Repeat(query.Number, query.Counter).ToList();
            Console.WriteLine(string.Join(", ", longestSubsequeneceLinq));
            Console.WriteLine();
        }
    }
}
