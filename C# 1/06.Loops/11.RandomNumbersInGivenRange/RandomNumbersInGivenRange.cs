using System;


namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            //Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter max: ");
            int max = int.Parse(Console.ReadLine());

            if (min == max)
            {
                Console.WriteLine("min should be different from max!");
                return;
            }

            int[] nums = new int[n];
            Random random = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(min, max + 1);
                Console.Write("{0} ", nums[i]);                
            }
            Console.WriteLine();
        }
    }
}
