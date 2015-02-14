using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MaxIncrSeq
{
    class MaxIncrSeq
    {
        static void Main()
        {
          //  Write a program that finds the maximal increasing sequence in an array.

            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int counter = 0;
            int max = 0;
            int lastIndex = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter > max)
                {
                    max = counter;
                    lastIndex = i + 1;
                }
            }

            int index = lastIndex - max;
            for (int i = index; i <= lastIndex; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}
