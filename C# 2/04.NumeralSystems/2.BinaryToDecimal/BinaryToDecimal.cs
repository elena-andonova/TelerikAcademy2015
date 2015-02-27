using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.
*/
namespace _2.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Please enter a binary integer number: ");
            string bin = Console.ReadLine();
            char[] binArr = bin.ToCharArray();
            int[] num = new int[binArr.Length];
            for (int i = 0; i < binArr.Length; i++)
            {
                num[i] = (int)(Char.GetNumericValue(binArr[i]));
            }
            long decNum = 0;
            long pow = 1;
            int baseNum = 2;
            for (int i = 1; i < num.Length; i++)
            {
                pow = pow * baseNum;
                //pow = (long)(Math.Pow(baseNum, (num.Length - i)));
                //Console.WriteLine(pow);
                //decNum += pow * num[i];
                decNum += (pow * num[(num.Length - 1) - i]);
            }
            decNum = num[num.Length - 1] + decNum;
            Console.WriteLine(decNum); 
        }
    }
}
