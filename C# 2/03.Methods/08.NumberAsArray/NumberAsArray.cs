using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberAsArray
{
    class NumberAsArray
    {
        
    //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    //Each of the numbers that will be added could have up to 10 000 digits.

        static void Main()
        {
            int firstNum = 201;
            int secNum = 403;

            if (firstNum > 10000 || secNum > 10000)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            string numAsArr = NumberAsArraysMethod(firstNum, secNum);
            Console.WriteLine(numAsArr);
        }

        static string NumberAsArraysMethod(int firstNum, int secNum)
        {
            int number = firstNum + secNum;
            string numStr = number.ToString();
            char[] numChar = numStr.ToCharArray();
            Array.Reverse(numChar);
            string numRepres = new string (numChar);

            return numRepres;
        }
    }
}
