namespace _03.SortingNumbers
{
    using System;
    using System.Collections.Generic;

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

            string numbersToString = null;
            numbers.Sort();
            numbers.ForEach(n => numbersToString += n.ToString() + " ");

            Console.WriteLine("-- Here are the numbers sorted increasingly --");
            Console.WriteLine(numbersToString);
        }
    }
}
