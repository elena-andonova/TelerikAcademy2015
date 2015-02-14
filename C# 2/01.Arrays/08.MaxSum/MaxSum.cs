using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaxSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            //Write a program that finds the sequence of maximal sum in given array.

            int[] nums = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int counter = 0;
           // int maxCount = 0;
            int sum = nums[0];
            int maxSum = nums[0];
            int lastIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    counter++;
                    lastIndex = i;
                 } 
                else
                {
                    sum = nums[i];
                    counter = 0;
                }
            }
            Console.WriteLine(lastIndex);
            Console.WriteLine(counter);
            int index = lastIndex - counter;
            //for (int i = index; i <= lastIndex; i++)
            //{
            //    Console.Write("{0} ", nums[i]);
            //}
            //Console.WriteLine();
        }
    }
}
