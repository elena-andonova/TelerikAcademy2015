using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class NFactorial
    {
        
//    Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
        static void Main()
        {
            int number = 5;

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            BigInteger factOfNum = Factorial(number);
            Console.WriteLine(factOfNum);
        }

        static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
