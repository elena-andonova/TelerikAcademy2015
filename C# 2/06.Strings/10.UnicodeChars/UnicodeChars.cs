using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
*/
namespace _10.UnicodeChars
{
    class UnicodeChars
    {
        static void Main()
        {
            string line = "Hi!";
            string lineUnicode = GetUnicodeString(line);
            Console.WriteLine(lineUnicode);
        }
        static string GetUnicodeString(string s)
        {
            StringBuilder uni = new StringBuilder();
            foreach (char c in s)
            {
                uni.Append("\\u");
                uni.Append(String.Format("{0:x4}", (int)c));
            }
            return uni.ToString();
        }
    }
}
