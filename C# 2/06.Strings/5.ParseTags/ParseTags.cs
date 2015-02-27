using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/
namespace _5.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string startTag = "<upcase>";
            string endTag = "</upcase>";
            int counter = Counter(text, startTag);
            text = ReplacingSubstrings(text, counter, startTag, endTag);
            Console.WriteLine(text);
        }

        static string ReplacingSubstrings(string text, int counter, string startTag, string endTag)
        {
            for (int i = 0; i < counter; i++)
            {
                int indexStart = text.IndexOf(startTag);
                //Console.WriteLine(indexStart);
                int indexEnd = text.IndexOf(endTag);
                //Console.WriteLine(indexEnd);

                int lengthToReplace = (indexEnd + endTag.Length) - indexStart;
                string stringToReplace = text.Substring(indexStart, lengthToReplace);
                int lengthReplacing = indexEnd - (indexStart + startTag.Length);
                string replacingString = text.Substring(indexStart + startTag.Length, lengthReplacing);
                //Console.WriteLine(replacingString);
                text = text.Replace(stringToReplace, replacingString.ToUpper());
            }
            return text;
        }

        static int Counter(string text, string startTag)
        {
            int counter = 0;
            for (int i = 0; i < text.Length - startTag.Length; i++)
            {
                string subTemp = text.Substring(i, startTag.Length);
                int isTheSame = string.Compare(subTemp, startTag, true);
                if (isTheSame == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
