using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/
namespace _7.EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine(); // "Test";
            string cypher = Console.ReadLine(); //"ab";
            string encodedLine = EncodingDecoding(line, cypher);
            //encodedLine = GetUnicodeString(encodedLine);
            Console.WriteLine(encodedLine);
            string decodedLine = EncodingDecoding(encodedLine, cypher);
            Console.WriteLine(decodedLine);
        }

        static string EncodingDecoding(string line, string cypher)
        {
            StringBuilder encodedDecoded = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                encodedDecoded.Append((char)(line[i] ^ cypher[i % cypher.Length]));
                //Console.WriteLine(i % cypher.Length);
            }
            return encodedDecoded.ToString();
        }

        //static string GetUnicodeString(string s)
        //{
        //    StringBuilder uni = new StringBuilder();
        //    foreach (char c in s)
        //    {
        //        uni.Append("\\u");
        //        uni.Append(String.Format("{0:x4}", (int)c));
        //    }
        //    return uni.ToString();
        //}
    }
}
