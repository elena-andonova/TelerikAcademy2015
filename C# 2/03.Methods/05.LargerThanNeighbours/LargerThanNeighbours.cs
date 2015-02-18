using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
        static void Main(string[] args)
        {
            int[] arr = { 1, 24, 3, 54, 54, 2, 32, 23, 4, 22, 3 };
            int position = 1;
            bool isBigger = LargerThanNeighboursMethod(position, arr);
            Console.WriteLine("The number at this position is bigger than its two neighbours? : {0}", isBigger);
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
