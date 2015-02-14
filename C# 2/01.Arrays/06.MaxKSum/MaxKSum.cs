 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxKSum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {            
    //Write a program that reads two integer numbers N and K and an array of N elements from the console.
    //Find in the array those K elements that have maximal sum.
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            Console.WriteLine("K = ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            // find the max number k times.

            int[] maxNums = new int[k];


        }
    }
}
