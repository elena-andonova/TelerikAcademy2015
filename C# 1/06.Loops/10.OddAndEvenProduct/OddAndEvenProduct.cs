using System;


namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {            
    //You are given n integers (given in a single line, separated by a space).
    //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            Console.Write("Please enter the numbers:");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            int[] nums = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }

            int odd_product = 1;
            int even_product = 1;
            int product = 1;
            string areEqual;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd_product *= nums[i];
                }
                else
                {
                    even_product *= nums[i];
                }
            }
            
            if (odd_product == even_product)
            {
                product = odd_product;
                areEqual = "yes";
                //Console.WriteLine("product = {0}", product);
                Console.WriteLine(areEqual);
            }
            else
            {
                areEqual = "no";
                //Console.WriteLine("odd_product = {0}", odd_product);
                //Console.WriteLine("even_product = {0}", even_product);
                Console.WriteLine(areEqual);
            }
        }
    }
}
