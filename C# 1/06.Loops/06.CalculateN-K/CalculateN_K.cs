using System;
using System.Numerics;


namespace _06.CalculateN_K
{
    class CalculateN_K
    {
        static void Main()
        {
            
    //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    //Use only one loop.

            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter k: ");
            int k = int.Parse(Console.ReadLine());
            
            if ((1 < k && k < n && n < 100) == false)
            {
                Console.WriteLine("The condition (1 < k < n < 100) is not fulfilled!");
                return;
            }

            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger res = 0;
            
            for (int i = 1; i <= n; i++)
            {
                factN = factN * i;
                //Console.WriteLine(factN);
                if (i <= k)
                {
                    factK = factK * i;
                   //Console.WriteLine(factK);                    
                }                  
            }
            res = factN / factK;
            Console.WriteLine("{0}", res);
        }
    }
}
