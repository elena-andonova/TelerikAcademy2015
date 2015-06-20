using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extensions
{
    //Problem 1. StringBuilder.Substring
    //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder initialString, int index, int length)
        {
            StringBuilder substringed = new StringBuilder();

            bool indexIssue = index < 0 | index > initialString.Length;
            bool lengthIssue = length <= 0 | length > initialString.Length - index;

            if (indexIssue | lengthIssue)
            {
                throw new ArgumentOutOfRangeException("The index and/or the length are out of range!");
            }

            for (int i = index; i < index + length; i++)
			{
                substringed.Append(initialString[i]);
			}

            return substringed;
        }
    }
}
