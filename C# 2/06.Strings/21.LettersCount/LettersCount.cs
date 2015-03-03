using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*Problem 21. Letters count

    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/
namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string line = "mimemamumu";
            line = Regex.Replace(line, @"[^\w]", "");
            line = line.ToLower();
            Dictionary<char, int> letters = new Dictionary<char, int> { };
            char firstLetter = line[0];
            letters[firstLetter] = 1;
            for (int i = 1; i < line.Length; i++)
            {
                if (letters.ContainsKey(line[i]))
                {
                    letters[line[i]] += 1;
                }
                else
                {
                    letters[line[i]] = 1;
                }
            }
            PrintDict(letters);
        }

        static void PrintDict(Dictionary<char, int> myDict)
        {
            foreach (var entry in myDict)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }
        }
    }
}
