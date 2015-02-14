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

            // find the max number k times.

            List<int> numsList = nums.ToList();
            List<int> maxKNums = new List<int> { };
            int maxNum = numsList[0];
            int indexToRemove = 0;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < numsList.Count; j++)
                {
                    if (numsList[j] > maxNum)
                    {
                        maxNum = numsList[j];
                        indexToRemove = j;
                    }
                }
                maxKNums.Add(maxNum);
                numsList.RemoveAt(indexToRemove);
                indexToRemove = 0;
                maxNum = numsList[0];
            }

            string forPrint = string.Join(", ", maxKNums);
            Console.WriteLine(forPrint);

        }
    }
}
