
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.
*/
namespace _13.ReverseSnt
{
    class ReverseSent
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            sentence = ReverseWords(sentence);
            Console.WriteLine(sentence);
        }
        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ', ',', '.', '!', '?');
            Array.Reverse(words);
            return string.Join("", words);
        }
    }
}
