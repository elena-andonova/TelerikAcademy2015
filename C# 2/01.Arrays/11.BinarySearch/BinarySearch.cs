using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

            Console.Write("Array: ");
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //{ 1, 3, 4, 6, 8, 9, 11 };
            Array.Sort(nums);
            Console.Write("Element: ");
            int element = int.Parse(Console.ReadLine()); //9; 

            int index = 0;
            int min = 0;
            int max = nums.Length - 1;

            while (max >= min)
            {
                int mid = ((min + max) / 2);
                if (element == nums[mid])
                {
                    index = mid;
                    break;
                }
                else if (element > nums[mid])
                {
                    min = mid + 1;
                }
                else 
                {
                    max = mid - 1;
                }
            }

            Console.WriteLine("Index: {0}", index);

        }
    }
}
