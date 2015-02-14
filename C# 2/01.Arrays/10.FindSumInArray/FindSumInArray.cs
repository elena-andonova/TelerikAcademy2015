using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).
            // , 2, 100 , -102 -- 0

            int[] arr = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            int sum = 11;
            int sumCandidate = 0;
            int firstIndex = 0;
            int lastIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumCandidate = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sumCandidate += arr[j];
                    
                    if (sumCandidate == sum)
                    {
                        firstIndex = i;
                        lastIndex = j;                        
                        //Console.WriteLine("{0}, {1}", firstIndex, lastIndex);
                        break;
                    }                   
                }                  
            }

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
