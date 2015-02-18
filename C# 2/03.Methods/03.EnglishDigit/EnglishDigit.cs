using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        //Write a method that returns the last digit of given integer as an English word.
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string word = EnglishDigitMethod(number);
            Console.WriteLine(word);
        }

        static string EnglishDigitMethod(int number)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = number % 10;
            string digitWord = digits[digit];
            return digitWord;
        }
    }
}
