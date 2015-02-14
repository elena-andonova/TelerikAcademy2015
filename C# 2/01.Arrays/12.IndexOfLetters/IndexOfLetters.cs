using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            
    //Write a program that creates an array containing all letters from the alphabet (A-Z).
    //Read a word from the console and print the index of each of its letters in the array.

            char firstLetterChar = 'A';
            char lastLetterChar = 'Z';
            int firstLetter = Convert.ToInt32(firstLetterChar);
            int lastLetter = Convert.ToInt32(lastLetterChar);
            int length = lastLetter - firstLetter + 1;
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
            {
                letters[i] = Convert.ToChar(i + firstLetter);
                //Console.WriteLine(letters[i]);
            }

            Console.WriteLine("Say the word: ");
            string line = Console.ReadLine();
            line = line.ToUpper();
            foreach (char c in line)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (c == letters[i])
                    {
                        Console.WriteLine("{0} --> {1}", c, i);
                    }
                }
            }

            
        }
    }
}
