using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {            
    //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());

            if ((0 <= n && n <= 100) == false)
            {
                Console.WriteLine("The condition (0 <= n <= 100) is not fulfilled!");
                return;
            }
            
            int nMulti2 = 2 * n;
            int nPlus1 = n + 1;
            BigInteger factN = 1;
            BigInteger factNMulti2 = 1;
            BigInteger factNPlus1 = 1;
            BigInteger res = 0;

            for (int i = 1; i <= nMulti2; i++)
            {
                factNMulti2 = factNMulti2 * i;
                //Console.WriteLine(factN);
                if (i <= nPlus1)
                {
                    factNPlus1 = factNPlus1 * i;
                    //Console.WriteLine(factK);    
                    if (i <= n)
                    {
                        factN = factN * i;
                    }
                }
            }
            res = factNMulti2 / (factNPlus1 * factN);
            Console.WriteLine("{0}", res);
        }
    }
}
