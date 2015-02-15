using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            //You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
            string[] arr = { "are", "given", "an", "strings", "characters", "method", "its" };
            string temp = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j].Length < arr[i].Length)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            //Array.Sort(arr);
            string sortedArr = string.Join(", ", arr);
            Console.WriteLine(sortedArr);
        }
    }
}
