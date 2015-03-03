using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        
    //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    //    If an invalid number or non-number text is entered, the method should throw an exception.
    //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        static void Main()
        {
            int start = 1;
            int end = 100;
            int numbers = 10;

            for (int i = 1; i <= numbers; i++)
            {
                Console.Write("Number {0} = ", i);
                try
                {
                    int num = ReadNumber(start, end);
                    start = num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Number is required!");
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message, start, end);
                    break;
                }
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || (number > end))
            {
                throw new ArgumentOutOfRangeException("Number should be in [{0},{1}]!");
            }
            return number;
        }
    }
}
