using System;


namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 2; i < 12; i++)
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
