using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
*/
namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            string fileLocation1 = @"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\Test.txt";
            StreamReader reader1 = new StreamReader(fileLocation1);
            string line1 = "";
            string fileLocation2 = @"D:\Telerik Academy\Homeworks\C# 2\08.TextFiles\Test2.txt";
            StreamReader reader2 = new StreamReader(fileLocation2);
            string line2 = "";

            using (reader1)
            {
                line1 = reader1.ReadToEnd();
            }
            using (reader2)
            {
                line2 = reader2.ReadToEnd();
            }


            string[] lines1 = line1.Split('\n');
            string[] lines2 = line2.Split('\n');
            int same = 0;
            int different = 0;

            for (int i = 0; i < lines1.Length; i++)  //Assuming the files have equal number of lines.
            {
                if (lines1[i] == lines2[i])
                {
                    Console.WriteLine("Line {0} is the SAME!", i + 1, lines1[i]);
                    same++;
                }
                else
                {
                    Console.WriteLine("Line {0} is DIFFERENT!", i + 1, lines1[i]);
                    different++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The number of same lines is {0}", same);
            Console.WriteLine("The number of different lines is {0}", different);
        }
    }
}
