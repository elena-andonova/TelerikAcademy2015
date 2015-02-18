using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is workings correctly.

        static void Main()
        {
            int number = 5;
            int[] arr = { 1, 2, 4, 5, 3, 5, 7, 6, 5 , 3};
            
            int counter = AppearanceCountMethod(number, arr);
            List<int> arrToList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    arrToList.Add(arr[i]);
                }
            }

            if (counter == arrToList.Count)
            {
                Console.WriteLine("The method works correctly!");
            }
            else
            {
                Console.WriteLine("The method does NOT work correctly!");
            }
        }

        static int AppearanceCountMethod(int number, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
