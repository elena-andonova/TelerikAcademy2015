using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/
namespace _9.ForbiddenText
{
    class ForbiddenText
    {
        static void Main()
        {
            string[] forbidden = { "PHP", "CLR", "Microsoft" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            text = forbiddenWords(forbidden, text);
            Console.WriteLine(text);
        }

         static string forbiddenWords(string[] forbidden, string text)
        {
            for (int i = 0; i < forbidden.Length; i++)
            {

                string word = forbidden[i];
                for (int j = 0; j < text.Length - word.Length; j++)
                {
                    string replacing = "".PadLeft(word.Length, '*');
                    text = text.Replace(word, replacing);
                }
            }

            return text;
        }
    }
}
