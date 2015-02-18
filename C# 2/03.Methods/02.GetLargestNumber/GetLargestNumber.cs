using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        
    //Write a method GetMax() with two parameters that returns the larger of two integers.
    //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

        static void Main()
        {
            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            int tempMax = GetMax(firstNum, secNum);
            int max = GetMax(tempMax, thirdNum);
            Console.WriteLine("The largest number is: {0}", max);
        }

        static int GetMax(int n1, int n2)
        {
            int max;
            if (n1 >= n2)
            {
                max = n1;
            }
            else
            {
                max = n2;
            }
            return max;
        }
    }
}
