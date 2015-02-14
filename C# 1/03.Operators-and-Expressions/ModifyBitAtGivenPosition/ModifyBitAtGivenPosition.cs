using System;


namespace ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            int number = 5;
            string binaryNum = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("The number {0} represented in binary is {1}", number, binaryNum);
            int position = 2;
            int value = 0;
            int mask = 1;
            int numAndMask = number & mask;
            string stringNumAndMask = Convert.ToString(numAndMask, 2).PadLeft(16, '0');
            if (value == 0)
            {
                mask = ~(1 << position);
                string strMask = Convert.ToString(mask, 2).PadLeft(16, '0');
                Console.WriteLine("The mask {0} is {1}", mask, strMask); 
            }
            else
            {
                mask = 1 << position;
                string strMask = Convert.ToString(mask, 2).PadLeft(16, '0');
                Console.WriteLine("The mask {0} is {1}", mask, strMask);
            }
            Console.WriteLine("Changing bit in position {0} to {1} returns {2} , which is {3}", position, value, stringNumAndMask, numAndMask);      
        }
    }
}
