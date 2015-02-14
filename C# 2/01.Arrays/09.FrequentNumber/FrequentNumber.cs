using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            //Write a program that finds the most frequent number in an array.

            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //{ 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 1, 3, 1, 1 };
            List<int> freqNums = new List<int> { };
            int mostFreqNum = nums[0];
            int frequence = 1;
            int tempNum = nums[0];
            int counter = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                tempNum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == tempNum)
                    {
                        counter++;
                    }
                }
                
                if (counter > frequence)
                {
                    mostFreqNum = tempNum;
                    frequence = counter;
                }
                counter = 1;
            }

            if (counter > 1)
            {
                Console.WriteLine("Most frequent number: {0} (with frequence {1})",
                            mostFreqNum, frequence);
            }
            else
            {
                Console.WriteLine("You have every number only once.");
            }

        }
    }
}
