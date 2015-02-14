using System;


namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            int number = 5343;
            string binaryNum = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("The number {0} represented in binary is {1}", number, binaryNum);
            int position = 7;
            int mask = 1 << position;
            int numbAndMask = number & mask;
            int bit = numbAndMask >> position;
            Console.WriteLine("And the bit at position {0} is {1}", position, bit);
        }
    }
}
