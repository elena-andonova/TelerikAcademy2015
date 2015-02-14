using System;


namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("The number is not positive!");
            }

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }                
            }
        }
    }
}
