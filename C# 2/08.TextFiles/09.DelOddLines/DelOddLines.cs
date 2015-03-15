using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
*/
namespace _09.DelOddLines
{
    class DelOddLines
    {
        static void Main(string[] args)
        {
            string fileLocation = @"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\Test.txt";
            StreamReader reader = new StreamReader(fileLocation);
            
            string line = "";

            using (reader)
            {
                line = reader.ReadToEnd();
            }

            string[] lines = line.Split('\n');

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
