using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        //Write a method that reverses the digits of given decimal number.
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double number = Convert.ToDouble(Console.ReadLine()); // 123.45;
            double reverse = ReverseNumberMethod(number);
            Console.WriteLine(reverse);
        }

        static double ReverseNumberMethod(double number)
        {
            string numString = number.ToString();
            char[] numberArr = numString.ToCharArray();
            Array.Reverse(numberArr);
            string numReverse = new string(numberArr);
            double reverse = Convert.ToDouble(numReverse);    
            return reverse;
        }

    }
}
