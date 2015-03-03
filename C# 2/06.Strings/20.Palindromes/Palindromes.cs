using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/
namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = "ABBA lamal, exe! kh;asd";
            Console.WriteLine(text);
            Console.WriteLine();

            string[] words = GetArrFromWords(text);
            PrintPalindromes(words);
        }

        static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool IsPalindrom(string word)
        {
            word = word.ToLower();
            string reverseWord = Reverse(word);
            if (reverseWord == word)
            {
                return true;
            }
            return false;
        }
        static void PrintPalindromes(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindrom(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
        static string[] GetArrFromWords(string text)
        {
            text = Regex.Replace(text, @"[^\w\s]", "");
            string[] words = text.Split(' ');
            return words;
        }
    }
}
