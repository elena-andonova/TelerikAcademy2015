using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.
*/
namespace _1.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            long num = long.Parse(Console.ReadLine());
            string[] bin = new string[32];
            int baseNum = 2;
            do
            {
                //num = num / baseNum;
                //Console.WriteLine(num);
                for (int i = 0; i < bin.Length; i++)
                {
                    if (num % baseNum == 0)
                    {
                        num = num / baseNum;
                        bin[(bin.Length - 1) - i] = "0";
                    }
                    else
                    {
                        num = num / baseNum;
                        bin[(bin.Length - 1) - i] = "1";
                    }
                }
            }
            while (num != 0);
            Console.WriteLine(string.Join("", bin));
        }
    }
}
