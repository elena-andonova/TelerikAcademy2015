using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
*/
namespace _03.LineNums
{
    class LineNums
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\file.txt");
            StreamWriter writer = new StreamWriter(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\written.txt");
            List<string> readFile = new List<string> { };
            using (reader)
            {
                readFile.Add(reader.ReadLine());
                while (reader.ReadLine() != null)
                {
                    readFile.Add(reader.ReadLine());
                }
            }
            using (writer)
            {

                for (int i = 0; i < readFile.Count; i++)
                {
                    string strToWrite = (i + 1).ToString() + ") " + readFile[i];
                    writer.WriteLine(strToWrite);
                }
            }

        }
    }
}
