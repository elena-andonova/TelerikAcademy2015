using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiverseCommunication
{
    class MultiverseCommunication
    {
        public static Dictionary<string, int> codes = new Dictionary<string, int>{
                                               {"CHU", 0},
                                               {"TEL", 1},
                                               {"OFT", 2},
                                               {"IVA", 3},
                                               {"EMY", 4},
                                               {"VNB", 5},
                                               {"POQ", 6},
                                               {"ERI", 7},
                                               {"CAD", 8},
                                               {"K-A", 9},
                                               {"IIA", 10},
                                               {"YLO", 11},
                                               {"PLA", 12}
                                           };
        static void Main()
        {

            string input = Console.ReadLine(); //"TELERIK-ACADEMY";
            List<string> words = MessageToWords(input);

            long decimalRepr = 0;
            long pow = 1;
            int baseNum = 13;
            words.Reverse();
            //PrintList(words);
            if (words.Count >= 1 && words.Count < 9)
            {
                for (int i = 1; i < words.Count; i++)
                {
                    if (codes.ContainsKey(words[i]))
                    {
                    pow = pow * baseNum;
                    long temp = codes[words[i]];
                    decimalRepr += temp * pow;
                    }
                    /*else
                    {
                        throw new ArgumentException();
                    }*/

                }
                decimalRepr = codes[words[0]] + decimalRepr;
                Console.WriteLine(decimalRepr);
            }
        }

        static List<string> MessageToWords(string input)
        {
            List<string> words = new List<string> { };
            string temp = input[0].ToString();
            for (int i = 0; i < input.Length; i+=3)
            {
                temp = input.Substring(i, 3);
                //Console.WriteLine(temp);
                words.Add(temp);
                //temp += input[i];
                ////temp = temp.ToUpper();
                //foreach (var key in codes.Keys)
                //{
                //    if (temp == key)
                //    {
                //        words.Add(temp);
                //        temp = "";
                //    }
                //}
            }
            return words;
        }

        static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
}
