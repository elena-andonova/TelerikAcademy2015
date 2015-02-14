using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNums
{
    class PrimeNums
    {
        static void Main(string[] args)
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

            long n = 10000000;
            bool[] isPrime = new bool[n];

            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p < isPrime.Length; p++)
            {
                if (isPrime[p] == true)
                {
                    for (long j = 2; (p * j) < n; j++)
                    {
                        isPrime[p * j] = false;
                    }
                }
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            
        }
    }
}
