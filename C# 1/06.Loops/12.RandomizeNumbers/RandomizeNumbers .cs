using System;


namespace _12.RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main()
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            int min = 1;
            int max = n;
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
