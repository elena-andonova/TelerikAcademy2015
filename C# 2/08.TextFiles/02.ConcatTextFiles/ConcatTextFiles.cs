using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
*/
namespace _02.ConcatTextFiles
{
    class ConcatTextFiles
    {
        static void Main()
        {
            StreamReader reader1 = new StreamReader(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\file1.txt");
            StreamReader reader2 = new StreamReader(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\file2.txt");
            StreamWriter writer = new StreamWriter(@"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\written.txt");
            string strToWrite = "";
            using (reader1)
            {
                strToWrite += reader1.ReadToEnd();
                Console.WriteLine(strToWrite);
            }
            using (reader2)
            {
                strToWrite += reader2.ReadToEnd();
                Console.WriteLine(strToWrite);
            }
            using (writer)
            {
                writer.Write(strToWrite);
            }
        }
    }
}
