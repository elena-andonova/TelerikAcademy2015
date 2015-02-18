using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        
    //Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    //Use the method from the previous exercise.

        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 3, 54, 54, 2, 1, 2, 4, 4, 3 };
            int index = FirstLargerThanNeighboursMethod(arr);
            Console.WriteLine(index);
        }

        static int FirstLargerThanNeighboursMethod(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (LargerThanNeighboursMethod(i, arr) == true)
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
        static bool LargerThanNeighboursMethod(int position, int[] arr)
        {
            if (position == 0 || position == (arr.Length - 1))
            {
                return false;
            }
            else if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
