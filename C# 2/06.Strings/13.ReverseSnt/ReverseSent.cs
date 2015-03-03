
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
        static public string[] PUNCT = { ",", ".", "!?", "!", "...", "?", ";", ":" };
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(sentence);

            string[] words = sentence.Split(' ');
            Dictionary<string, List<int>> punctPositions = new Dictionary<string, List<int>>();
            PunctSeekAndRemove(words, punctPositions);
            Array.Reverse(words);
            AddBackThePunct(words, punctPositions);
            string reversedSentence = string.Join(" ", words);
            Console.WriteLine(reversedSentence);
        }

        static void PunctSeekAndRemove(string[] words, Dictionary<string, List<int>> punctPositions)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string isContainigPunct = isTherePunct(words[i]);
                if (!String.IsNullOrEmpty(isContainigPunct))
                {
                    if (punctPositions.ContainsKey(isContainigPunct))
                    {
                        punctPositions[isContainigPunct].Add(i);
                    }
                    else
                    {
                        punctPositions.Add(isContainigPunct, new List<int> { });
                        punctPositions[isContainigPunct].Add(i);
                    }
                }
                string cleanedWord = ClearPunct(words[i]);
                words[i] = cleanedWord;
            }
        }

        static string isTherePunct(string str)
        {
            string answer = "";
            for (int i = 0; i < PUNCT.Length; i++)
            {
                if (str.Contains(PUNCT[i]))
                {
                    answer += PUNCT[i];
                    return answer;
                }
            }
            return answer;
        }
        static void AddBackThePunct(string[] wordsReversed, Dictionary<string, List<int>> punctPositions)
        {
            foreach (var punctKey in punctPositions.Keys)
            {
                //List<int> theList = myDictDB[punctKey];
                foreach (var position in punctPositions[punctKey])
                {
                    wordsReversed[position] += punctKey;
                }
            }
        }
        static void PrintDict(Dictionary<string, List<int>> myDict)
        {
            foreach (var item in myDict.Keys)
            {
                Console.WriteLine(item);
                List<int> theList = myDict[item];
                foreach (var num in theList)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static string ClearPunct(string str)
        {
            string newStr = "";
            for (int i = 0; i < PUNCT.Length; i++)
            {
                if (str.Contains(PUNCT[i]))
                {
                    str = str.Replace(PUNCT[i], "");
                }
            }
            newStr = str;
            return newStr;
        }

    }
}
