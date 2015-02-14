using System;
using System.Linq;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
    //Write a program that reads two integer arrays from the console and compares them element by element.            
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length;
            if (firstArr.Length > secArr.Length)
            {
                length = secArr.Length;
            }
            else
            {
                length = firstArr.Length;
            }

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] > secArr[i])
                {
                    Console.WriteLine("{0} > {1}", firstArr[i], secArr[i]);
                }
                else if (firstArr[i] < secArr[i])
                {
                    Console.WriteLine("{0} < {1}", firstArr[i], secArr[i]);
                }
                else 
                {
                    Console.WriteLine("{0} = {1}", firstArr[i], secArr[i]);
                }
            }

        }
    }
}
