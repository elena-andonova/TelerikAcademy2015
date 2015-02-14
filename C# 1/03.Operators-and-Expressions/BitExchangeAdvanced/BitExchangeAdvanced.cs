using System;


namespace BitExchangeAdvanced
{
    class Program
    {
        static void Main()
        {
            uint n = 4294901775;
            string binaryNum = Convert.ToString(n, 2).PadLeft(32, '0');
            Console.WriteLine(binaryNum);
            char[] arrayNum = binaryNum.ToCharArray();
            int charLength = 31;    //Because the counting starts from '0' instead from '1'.
            int p = 24;
            int q = 3;
            int k = 3;
            int pos = charLength - p;   //Because in the char array the counting is from left to right.
            int newPos = charLength - q;
            char temp;

            if (((p > q) && (p + k - 1) < q) || ((p < q) && (p + k - 1) > q))
            {
                Console.WriteLine("The first and the second sequence of bits are overlapping.");
            }
            else
            {                
                do
                {
                    temp = arrayNum[pos];
                    arrayNum[pos] = arrayNum[newPos];
                    arrayNum[newPos] = temp;
                    pos--;
                    newPos--;
                }
                while (pos >= (charLength - (p + k - 1)) && newPos >= (charLength - (q + k - 1)));

                string newBinaryNum = new string(arrayNum);
                Console.WriteLine(newBinaryNum);   
                uint newN = Convert.ToUInt32(newBinaryNum, 2);
                Console.WriteLine(newN); 
            }
        }
    }
}
