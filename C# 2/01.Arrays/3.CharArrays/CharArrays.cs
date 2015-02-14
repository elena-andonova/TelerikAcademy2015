using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CharArrays
{
    class CharArrays
    {
        static void Main()
        {
   // Write a program that compares two char arrays lexicographically (letter by letter).

            string firstLine = Console.ReadLine();
            string secLine = Console.ReadLine();

            int length = Math.Min(firstLine.Length, secLine.Length);


            for (int i = 0; i < length; i++)
            {
                if (Convert.ToInt32(firstLine[i]) > Convert.ToInt32(secLine[i]))
                {
                    Console.WriteLine("{0} > {1}", firstLine[i], secLine[i]);
                }
                else if (Convert.ToInt32(firstLine[i]) < Convert.ToInt32(secLine[i]))
                {
                    Console.WriteLine("{0} < {1}", firstLine[i], secLine[i]);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", firstLine[i], secLine[i]);
                }
            }

        }
    }
}
