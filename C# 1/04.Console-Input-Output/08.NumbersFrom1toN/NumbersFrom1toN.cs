using System;
using System.Globalization;
using System.Threading;


namespace _08.NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter a number.");
            Console.Write("n=");
            string line = Console.ReadLine();
            int n = int.Parse(line);
            int[] nums = new int[n];
            int j = 1;
            for (int i = 0; i < n; i++)
            {                
                nums[i] = j;
                j++;
                Console.WriteLine(nums[i]);
            }
        }
    }
}
