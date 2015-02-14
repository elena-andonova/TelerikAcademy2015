using System;
using System.Numerics;

namespace _07.CalculateN__K_N_K__
{
    class CalculateN__K_N_K__
    {
        static void Main()
        {

            //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated by the following formula: formula 
            //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter k: ");
            int k = int.Parse(Console.ReadLine());

            if ((1 < k && k < n && n < 100) == false)
            {
                Console.WriteLine("The condition (1 < k < n < 100) is not fulfilled!");
            }
            return;

            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factNK = 1;
            int d = n - k;
            bool isBigger = d > k;
            //Console.WriteLine(d);
            BigInteger res = 0;

            for (int i = 1; i <= n; i++)
            {
                factN = factN * i;
                switch (isBigger)
                {
                    case true:
                        if (i <= d)
                        {
                            factNK = factNK * i;
                            if (i <= k)
                            {
                                factK = factK * i;
                            }
                        }
                        break;

                    case false:
                        if (i <= k)
                        {
                            factK = factK * i;
                            if (i <= d)
                            {
                                factNK = factNK * i;
                            }
                        }
                        break;
                }

            }
            //Console.WriteLine(factN);
            //Console.WriteLine(factK);
            //Console.WriteLine(factNK);
            res = factN / (factK * factNK);
            Console.WriteLine("{0}", res);

        }
    }
}
