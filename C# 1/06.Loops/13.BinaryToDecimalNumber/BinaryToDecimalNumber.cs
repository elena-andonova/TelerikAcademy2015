using System;


namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            
    //Using loops write a program that converts a binary integer number to its decimal form.
    //The input is entered as string. The output should be a variable of type long.
    //Do not use the built-in .NET functionality.

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
