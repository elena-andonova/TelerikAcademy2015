using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
*/
namespace _11.PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            string fileLocation = @"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\PrefixTest.txt";
            StreamReader reader = new StreamReader(fileLocation);

            string line = "";

            using (reader)
            {
                line = reader.ReadToEnd();
            }

            //string[] lines = line.Split('\n');
            string pattern = @"\btest([A-Za-z0-9\^_]+)\s|test([A-Za-z0-9\^_]+)";
            string replace = "";
            string result = Regex.Replace(line, pattern, replace);
            Console.WriteLine(result);

            StreamWriter writer = new StreamWriter(fileLocation);
            using (writer)
            {
                writer.Write(result);
            }
        }
    }
}
