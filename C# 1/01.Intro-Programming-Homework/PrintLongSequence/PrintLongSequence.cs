using System;


namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int i;
            for (i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
