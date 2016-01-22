namespace HashTablesDictionariesSets
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {            
            // 1. Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
            double[] values = new double[] { 1, 2, 3, 2, 2.5, -5, 1, -5, 2, 3, 2.5 };
            var valuesOcc = GetValueOccurenceDouble(values);
            foreach (var item in valuesOcc)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            // 2. Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. 
            string[] elements = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var elementsDict = GetValueOccurenceString(elements);
            var oddElements = GetVOddElements(elementsDict);
            foreach (var item in oddElements)
            {
                Console.Write("{0} ", item);
            }

            // 3. Write a program that counts how many times each word from given text file words.txt appears in it. 
            // The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. 
            string filepath = @"..\..\words.txt";
            var words = ReadFromTextFile(filepath);
            var sortedWords = GetSortedValueOccurence(words);
            foreach (var word in sortedWords)
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }

        static Dictionary<double, int> GetValueOccurenceDouble(double[] values)
        {
            var valuesDict = new Dictionary<double, int>();
            for (int i = 0; i < values.Length; i++)
            {
                double value = values[i];
                if (valuesDict.ContainsKey(value))
                {
                    valuesDict[value] += 1;
                }
                else
                {
                    valuesDict[value] = 1;
                }
            }

            return valuesDict;
        }

        static Dictionary<string, int> GetValueOccurenceString(string[] values)
        {
            var valuesDict = new Dictionary<string, int>();
            for (int i = 0; i < values.Length; i++)
            {
                string value = values[i];
                if (valuesDict.ContainsKey(value))
                {
                    valuesDict[value] += 1;
                }
                else
                {
                    valuesDict[value] = 1;
                }
            }

            return valuesDict;
        }

        static Dictionary<string, int> GetSortedValueOccurence(string[] values)
        {
            var valuesDict = new Dictionary<string, int>();
            for (int i = 0; i < values.Length; i++)
            {
                string value = values[i];
                if (valuesDict.ContainsKey(value.ToLower()))
                {
                    valuesDict[value.ToLower()] += 1;
                }
                else
                {
                    valuesDict[value.ToLower()] = 1;
                }
            }

            var result = valuesDict.OrderBy(p => p.Value).ToDictionary(p => p.Key, p => p.Value);
            return result;
        }

        static List<string> GetVOddElements(Dictionary<string, int> values)
        {
            var oddValuesList = new List<string>();
            foreach (var item in values)
            {
                if (item.Value % 2 != 0)
                {
                    oddValuesList.Add(item.Key);
                }
            }

            return oddValuesList;
        }

        static string[] ReadFromTextFile(string filepath)
        {
            string readContents;
            using (StreamReader streamReader = new StreamReader(filepath, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }


            var words = Regex.Split(readContents, @"\W+");
                //readContents.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}
