using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Words
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(int.MaxValue);
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            var wordSplits = new List<string>();
            wordSplits.Add(word);

            if (word.Length > 1)
            {
                for (int k = 1; k < word.Length; k++)
                {
                    var variant1 = word.Substring(0, k);
                    var variant2 = word.Substring(k, word.Length - k);

                    wordSplits.Add(variant1);
                    wordSplits.Add(variant2);
                }
            }


            var occurrences = new List<int>();
            for (int i = 0; i < wordSplits.Count; i++)
            {
                var currentOccurrence = CountStringOccurrences(text, wordSplits[i]);
                occurrences.Add(currentOccurrence);
                //Console.WriteLine(currentOccurrence);
            }

            var combinations = occurrences[0];
            for (int i = 2; i < occurrences.Count; i += 2)
            {
                var calc = occurrences[i] * occurrences[i - 1];
                //Console.WriteLine(calc);
                combinations += calc;
            }

            Console.WriteLine(combinations);
        }

        // Source: http://www.dotnetperls.com/string-occurrence
        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}

