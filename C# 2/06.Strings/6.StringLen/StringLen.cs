using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
*/
namespace _6.StringLen
{
    class StringLen
    {
        static void Main()
        {
            string line = Console.ReadLine();
            int maxLength = 20;
            if (line.Length > maxLength)
            {
                Console.WriteLine("Invalid input! The string length must be <= 20!");
            }
            else
            {
                Console.WriteLine(line.PadRight(maxLength, '*'));
            }
        }
    }
}
