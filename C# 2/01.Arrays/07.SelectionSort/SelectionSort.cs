using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            
    //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    //Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //{ 64, 25, 12, 22, 11 };
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    temp = nums[i];
                    nums[i] = nums[minIndex];
                    nums[minIndex] = temp;
                }
            }

            string forPrint = string.Join(", ", nums);
            Console.WriteLine(forPrint);

        }
    }
}
