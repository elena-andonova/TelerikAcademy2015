using System;
using System.Globalization;
using System.Threading;


namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter two positive numbers.");
            Console.Write("Number 1 = ");
            string line = Console.ReadLine();
            uint num1 = uint.Parse(line);
            Console.Write("Number 2 = ");
            line = Console.ReadLine();
            uint num2 = uint.Parse(line);
            uint count = 0;           

            for (uint i = num1; i <= num2; i++) 
            {
                if (i % 5 == 0)
                {                    
                    count++;                                                                     
                }
            }

            Console.WriteLine("How many numbers exist between {0} and {1} such that the reminder of the divison by 5 is 0: {2}",
                                num1, num2, count);   
        }
    }
}
