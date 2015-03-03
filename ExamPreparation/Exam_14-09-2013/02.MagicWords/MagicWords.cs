using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MagicWords
{
    class MagicWords
    {
        static void Main()
        {
            int number = 4;
            if (number >= 1 && number <= 1000)
            {
                string[] arr = { "nakov", "wrote", "this", "problem" };
                string[] reordered = Reordering(arr);
                string sortedArr = string.Join(", ", reordered);
                Console.WriteLine(sortedArr);
                string print = Printing(reordered);
                Console.WriteLine(print);
            }

        }

        static string[] Reordering(string[] arr)
        {
            string temp = "";
            List<string> reordered = arr.ToList();

            for (int i = 0; i < reordered.Count; i++)
            {

                int wordLength = reordered[i].Length;
                int length = arr.Length + 1;

                //if( length % wordLength == 0)
                //{
                //    length = length / wordLength;
                //    wordLength = wordLength / wordLength;
                //}

                int wordPosition = wordLength % length;

                temp = reordered[i];
                reordered.RemoveAt(i);
                reordered.Insert(wordPosition, temp);

            }

            string[] reorderedWords = reordered.ToArray();
            return reorderedWords;
        }

        static string Printing(string[] arr)
        {
            string forPrint = "";
            int length = MaxLengthOfChars(arr);
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length > i)
                    {
                        forPrint += arr[j][i];
                    }
                }
            }

            return forPrint;
        }

        static int MaxLengthOfChars(string[] arr)
        {
            int maxLength = arr[0].Length;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {
                    maxLength = arr[i].Length;
                }
            }
            return maxLength;
        }
    }
}
