using System;


namespace ExtractBit3
{
    class ExtractBit3
    {
        static void Main()
        {
            int number = 62241;
            string binaryNum = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("The number {0} represented in binary is {1}", number, binaryNum);
            int position = 3;
            int mask = 1 << position;
            int numbAndMask = number & mask;
            int bit = numbAndMask >> position;
            Console.WriteLine("And the bit at position {0} is {1}", position, bit);
        }
    }
}
