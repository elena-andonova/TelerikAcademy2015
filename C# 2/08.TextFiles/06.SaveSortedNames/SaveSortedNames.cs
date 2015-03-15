using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. Save sorted names

    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/
namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\file.txt");
            StreamWriter writer = new StreamWriter(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\new.txt");
            List<string> readFile = new List<string> { };
            using (reader)
            {
                readFile.Add(reader.ReadLine());
                while (reader.ReadLine() != null)
                {
                    readFile.Add(reader.ReadLine());
                }
            }
            readFile.Sort();
            using (writer)
            {
                for (int i = 0; i < readFile.Count; i++)
                {
                    writer.WriteLine(readFile[i]);
                }
            }
        }
    }
}
