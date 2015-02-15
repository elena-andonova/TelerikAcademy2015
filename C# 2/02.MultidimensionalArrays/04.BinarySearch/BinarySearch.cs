using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
           // Write a program, that reads from the console an array of N integers and an integer K, 
           //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Num{0} = ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);
            //string sortedArr = string.Join(", ", nums);
            //Console.WriteLine(sortedArr);
            int kIndex = Array.BinarySearch(nums, k);
            int searchedIndex = 0;
            //Console.WriteLine(kIndex);
            if (kIndex < 0)
            {
                searchedIndex = (~kIndex) - 1;
            }
            else
            {
                searchedIndex = kIndex;
            }

            if (searchedIndex >= nums.Length)
            {
                searchedIndex = nums.Length - 1;
                Console.WriteLine("The largest number in the array which is <= K: {0}", nums[searchedIndex]);
            }
            if (searchedIndex < 0)
            {
                Console.WriteLine("There is no number in the array which is <= K!");
            }
            else
            {
                Console.WriteLine("The largest number in the array which is <= K: {0}", nums[searchedIndex]);
            }
            //Console.WriteLine(searchedIndex);
        }
    }
}
