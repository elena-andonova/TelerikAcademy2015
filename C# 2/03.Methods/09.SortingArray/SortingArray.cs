using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class SortingArray
    {
        
    //Write a method that return the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending / descending order.

        static void Main()
        {
            int[] arr = { 1, 2, 4, 5, 3, 5, 7, 6, 50, 3 };
            int index = 4;
            int max = arr[MaximalElementIndex(arr, index)];
            Console.WriteLine(max);
            SortingArrayMethod(arr);
        }

        static int MaximalElementIndex(int[] arr, int index)
        {
            int maxIndex = index;
            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[maxIndex] < arr[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void SortingArrayMethod(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int maxIndex = MaximalElementIndex(arr, i);
                if (arr[i] < arr[maxIndex])
                {
                    temp = arr[maxIndex];
                    arr[maxIndex] = arr[i];
                    arr[i] = temp;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
