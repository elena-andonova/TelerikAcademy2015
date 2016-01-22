namespace _01.SumAndAvgOfList
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

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
                if (number >= 0)
                {
                   numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("The number should be positive!");
                }                
            }

            string numbersToString = null;
            numbers.ForEach(n => numbersToString += n.ToString() + " ");
            Console.WriteLine("The numbers are: {0}", numbersToString);

            var sum = numbers.Sum();
            Console.WriteLine("The sum is {0}", sum);

            var avg = sum / (numbers.Count);
            Console.WriteLine("The average is {0}", avg);
        }
    }
}
