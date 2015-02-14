using System;


namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            uint n = 2369124121;
            string binaryNum = Convert.ToString(n, 2).PadLeft(32, '0');
            Console.WriteLine(binaryNum);
            char[] arrayNum = binaryNum.ToCharArray();    
            int charLength = 31;    //Because the counting starts from '0' instead from '1'.
            int pos = charLength - 3;   //Because in the char array the counting is from left to right.
            int newPos = charLength - 24;
            char temp;

            do
            {
                temp = arrayNum[pos];
                arrayNum[pos] = arrayNum[newPos];
                arrayNum[newPos] = temp;
                pos--;
                newPos--;
            }
            while (pos >= (charLength - 5) && newPos >= (charLength - 26));

            string newBinaryNum = new string(arrayNum);
            Console.WriteLine(newBinaryNum);
            uint newN = Convert.ToUInt32(newBinaryNum, 2);
            Console.WriteLine(newN);            
        }
    }
}
