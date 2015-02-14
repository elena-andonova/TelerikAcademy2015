using System;
using System.Globalization;
using System.Threading;


namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter 5 numbers:");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            double[] nums = new double[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                nums[i] = double.Parse(strArr[i]);
            }

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
