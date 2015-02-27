using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.
*/
namespace _2.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string line = Console.ReadLine();//"sample";
            char[] arr = line.ToCharArray();
            Array.Reverse(arr);
            string reverse = new string(arr);
            Console.WriteLine(reverse);
        }
    }
}

