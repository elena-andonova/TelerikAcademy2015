using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.
*/
namespace _10.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static StringBuilder textWithoutTags = new StringBuilder();
        static void Main()
        {
            string pathXML = @"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\file.xml";
            ExtractTextWithoutTags(pathXML);
            Console.WriteLine(textWithoutTags);
        }
        static void ExtractTextWithoutTags(string pathTextFile)
        {
            using (StreamReader reader = new StreamReader(pathTextFile))
            {
                while (!reader.EndOfStream)
                {
                    string line = Regex.Replace(reader.ReadLine(), @"<[^>]*>", String.Empty).Trim();
                    if (line != "") textWithoutTags.AppendLine(line);
                }
            }
        }
    }
}
