using System;
using System.Numerics;


namespace _18.TrailingZeroesInNFact
{
    class TrailingZeroesInNFact
    {
        static void Main()
        {
            
    //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    //Your program should work well for very big numbers, e.g. n=100000.

            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;           
            }

            string factStr = fact.ToString();
            int counter = 0;
            char zero = '0';

            for (int i = factStr.Length - 1; i >= 0 ; i--)
            {
                if (factStr[i] == zero)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("trailing zeroes of n! : {0}", counter);
            //Console.WriteLine("{0}", fact);        
        }
    }
}
