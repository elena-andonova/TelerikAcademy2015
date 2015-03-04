using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            string fileLocation = @"D:\Telerik Academy\Homeworks\C# 2\textFiles\PrefixTest.txt";
            StreamReader reader = new StreamReader(fileLocation);

            string line = "";

            using (reader)
            {
                line = reader.ReadToEnd();
            }

            string[] lines = line.Split('\n');

            int index = line.IndexOf("foundme", 0);
            while (index != -1)
            {
                count++;
                index = text.IndexOf("foundme", index + 1);
            }
            Console.WriteLine(count);


            StreamWriter writer = new StreamWriter(fileLocation);
            using (writer)
            {
                for (int i = 0; i < lines.Length; i += 2)
                {
                    writer.WriteLine(lines[i]);
                    //Console.WriteLine("Line {0}: {1}", i + 1, lines[i]);
                }
            }
        }
    }
}
