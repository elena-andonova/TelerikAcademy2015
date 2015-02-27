using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. binary to hexadecimal

    Write a program to convert binary numbers to hexadecimal numbers (directly).
*/
namespace _6.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static string EachFromDecToHex(int decNum)
        {
            string hexNumStr = "";
            if (decNum < 10)
            {
                hexNumStr = decNum.ToString();
            }
            else
            {
                switch (decNum)
                {
                    case 10: hexNumStr = "A"; break;
                    case 11: hexNumStr = "B"; break;
                    case 12: hexNumStr = "C"; break;
                    case 13: hexNumStr = "D"; break;
                    case 14: hexNumStr = "E"; break;
                    case 15: hexNumStr = "F"; break;
                    default: hexNumStr = "Invalid"; break;
                }
            }
            return hexNumStr;
        }

        static int EachFourDigBinToDec(int[] num, int index)
        {
            int decNum = 0;
            int pow = 1;
            int baseNum = 2;
            for (int j = index; j < index + 3; j++)
            {
                pow = pow * baseNum;
                decNum += (pow * num[(index + (index + 3) - 1) - j]);
            }
            decNum = num[(index + 4) - 1] + decNum;
            //string decNumStr = decNum.ToString();
            return decNum;
        }
        static void Main()
        {
            Console.Write("Please enter a binary integer number: ");
            string bin = Console.ReadLine();
            if (bin.Length % 2 != 0)
            {
                bin = bin.PadLeft(bin.Length + 1, '0');
            }

            char[] binArr = bin.ToCharArray();
            int[] numArr = new int[binArr.Length];

            for (int i = 0; i < binArr.Length; i++)
            {
                numArr[i] = (int)(Char.GetNumericValue(binArr[i]));
            }

            string hex = "";
            for (int i = 0; i < numArr.Length; i += 4)
            {
                hex += EachFromDecToHex(EachFourDigBinToDec(numArr, i));
            }
            Console.WriteLine(hex);
        }
    }
}
