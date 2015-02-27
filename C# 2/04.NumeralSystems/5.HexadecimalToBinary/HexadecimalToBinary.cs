using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).
*/
namespace _5.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static string EachHexToBin(int num)
        {
            int baseNum = 2;
            string[] binEach = new string[4];
            do
            {
                //num = num / baseNum;
                //Console.WriteLine(num);
                for (int i = 0; i < binEach.Length; i++)
                {
                    if (num % baseNum == 0)
                    {
                        num = num / baseNum;
                        binEach[(binEach.Length - 1) - i] = "0";
                    }
                    else
                    {
                        num = num / baseNum;
                        binEach[(binEach.Length - 1) - i] = "1";
                    }
                }
            }
            while (num != 0);
            string binEachString = string.Join("", binEach);
            return binEachString;
        }
        static void Main()
        {
            Console.Write("Please enter a hexadecimal integer number: ");
            string hex = Console.ReadLine();  //"4A01";
            char[] hexArr = hex.ToCharArray();

            string binNumStr = "";
            int[] num = new int[hexArr.Length];
            for (int i = 0; i < hexArr.Length; i++)
            {
                if (Char.IsDigit(hexArr[i]) == true)
                {
                    num[i] = (int)(Char.GetNumericValue(hexArr[i]));
                }
                else
                {
                    switch (hexArr[i])
                    {
                        case 'A':
                            num[i] = 10;
                            break;
                        case 'B':
                            num[i] = 11;
                            break;
                        case 'C':
                            num[i] = 12;
                            break;
                        case 'D':
                            num[i] = 13;
                            break;
                        case 'E':
                            num[i] = 14;
                            break;
                        case 'F':
                            num[i] = 15;
                            break;
                    }
                }
               binNumStr += EachHexToBin(num[i]);
            }
            Console.WriteLine(binNumStr); 
        }
    }
}
