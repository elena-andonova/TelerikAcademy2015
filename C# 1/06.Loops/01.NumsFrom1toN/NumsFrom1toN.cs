using System;


namespace _01.NumsFrom1toN
{
    class NumsFrom1toN
    {
        static void Main()
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("The number is not positive!");                
            }
                        
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);                
            }
        }
    }
}
