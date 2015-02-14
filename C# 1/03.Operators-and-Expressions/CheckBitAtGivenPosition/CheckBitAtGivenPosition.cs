using System;


namespace CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            int number = 62241;
            string binaryNum = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("The number {0} represented in binary is {1}", number, binaryNum);
            int position = 11;
            int mask = 1 << position;
            int numbAndMask = number & mask;
            int bit = numbAndMask >> position;
            bool isBit1 = bit == 1;            
            Console.WriteLine("The bit at position {0} has value of 1 : {1}", position, isBit1);
        }
    }
}
