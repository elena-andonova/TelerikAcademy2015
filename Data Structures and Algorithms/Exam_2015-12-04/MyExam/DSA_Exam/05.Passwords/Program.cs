using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Passwords
{
    public static class Program
    {
        private const string digits = "1234567890";
        private const string digitsLexy = "0123456789";

        private const char right = '>';
        private const char left = '=';
        private const char inPlace = '=';

        public static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var directions = Console.ReadLine();
            var k = int.Parse(Console.ReadLine());

            var onlyRight = new string('>', 9);
            var onlyLeft = new string('<', 9);
            var onlyOnePlace = new string('=', 9);

            if (directions == onlyRight)
            {
                Console.WriteLine(digits);
            }
            if (directions == onlyLeft)
            {
                var reversedDigits = digits.Reverse();
                Console.WriteLine(reversedDigits);
            }

            var passes = new List<string>();

            GetCombination(length, directions, 0);


            //var result = new List<string>();
            //result.PutCombinations(0, 9, new int[2], 0);
            //Console.WriteLine(string.Join(", ", result));
        }

        private static void GetCombination(int length, string directions, int firstIndex)
        {
            var pass = new char[length];
            pass[0] = digits[firstIndex];
            int index = firstIndex;
            for (int i = 1; i < length; i++)
            {
                var dir = directions[i - 1];

                for (int k = 0; k < 9; k++)
                {
                    if (dir == right)
                    {
                        index = firstIndex + 1;              
                        for (int p = index; p < digits.Length; p++)
                        {
                            pass[i] = digits[p];
                        }
                    }
                    if (dir == left)
                    {
                        index = index - 1;
                    }
                    if (dir == inPlace)
                    {
                        index = firstIndex;
                    }
                    //pass[i] = digits[index];
                }
            }

            var passString = string.Join("", pass);
            //passes.Add(passString);
            Console.WriteLine(passString);

        }

        private static void PutCombinations(this IList<string> output, int startNumber, int endNumber, int[] placeholder, int index)
        {
            if (index == placeholder.Length)
            {
                output.Add(string.Format("({0})", string.Join(" ", placeholder)));
                return;
            }

            for (var number = startNumber; number <= endNumber; number++)
            {
                placeholder[index] = number;
                output.PutCombinations(number + 1, endNumber, placeholder, index + 1);
            }
        }
    }
}
