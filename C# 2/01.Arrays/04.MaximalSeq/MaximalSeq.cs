using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSeq
{
    class MaximalSeq
    {
        static void Main()
        {
   //Write a program that finds the maximal sequence of equal elements in an array.

            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int counter = 1;
            int max = 0;
            int num = nums[0];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > max)
                {
                    max = counter;
                    num = nums[i];
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0} ", num);
            }

        }
    }
}
