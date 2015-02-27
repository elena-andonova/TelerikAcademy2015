using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        
    //You are given a sequence of positive integer values written into a string, separated by spaces.
    //Write a function that reads these values from given string and calculates their sum.

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine(); // "43 68 9 23 318";
            int sum = SumOfSeqenceOfNumbers(input);
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }

        static int SumOfSeqenceOfNumbers(string line)
        {
            string[] strArr = line.Split(' ');
            int[] nums = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
