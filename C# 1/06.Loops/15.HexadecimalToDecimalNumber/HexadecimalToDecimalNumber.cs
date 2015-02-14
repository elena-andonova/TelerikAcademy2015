using System;


namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            
    //Using loops write a program that converts a hexadecimal integer number to its decimal form.
    //The input is entered as string. The output should be a variable of type long.
    //Do not use the built-in .NET functionality.

            Console.Write("Please enter a hexadecimal integer number: ");
            string hex = Console.ReadLine();
            char[] hexArr = hex.ToCharArray();
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
            }

            long decNum = 0;
            long pow = 1;
            int baseNum = 16;

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
