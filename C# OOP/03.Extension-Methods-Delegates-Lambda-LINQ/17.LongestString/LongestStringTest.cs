using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _17.LongestString
{
    //Problem 17. Longest string
    //Write a program to return the string with maximum length from an array of strings.
    //Use LINQ.

    class LongestStringTest
    {
        static void Main()
        {
            string text = "Write a program to return the string with maximum length from an array of strings. Elephants cannot do programming!?";
            string cleanedText = Regex.Replace(text, @"[^\w\s\-\+]", "");
            //Console.WriteLine(cleanedText);
            string[] words = cleanedText.Split(' ');
            var longest = words.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
        }
    }
}
