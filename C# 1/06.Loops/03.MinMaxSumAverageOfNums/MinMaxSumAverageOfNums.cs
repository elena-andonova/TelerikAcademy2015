using System;


namespace _03.MinMaxSumAverageOfNums
{
    class MinMaxSumAverageOfNums
    {
        static void Main()
        {            
    //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
    //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    //The output is like in the examples below.

            Console.Write("Please state how many numbers you will enter: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());             
            }
            int min = nums[0];
            int max = nums[0];
            int sum = 0;            

            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i]) min = nums[i];
                if (max < nums[i]) max = nums[i];
                sum += nums[i];                
            }
            double avg = Convert.ToDouble(sum) / n;

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2} ", avg);
        }
    }
}
