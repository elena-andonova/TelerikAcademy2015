using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        //Write a program that generates and prints to the console 10 random values in the range [100, 200].
        static void Main()
        {
            int num = 10;
            int[] randomArr = new int[num];
            int start = 100;
            int end = 200;
            Random randomNum = new Random(0);

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = randomNum.Next(start, end + 1);
            }

            string forPrint = string.Join(", ", randomArr);
            Console.WriteLine(forPrint);
        }
    }
}
