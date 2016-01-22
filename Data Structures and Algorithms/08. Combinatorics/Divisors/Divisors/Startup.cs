namespace Divisors
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {

            int numbersCount = int.Parse(Console.ReadLine());
            int[] inputNumbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }

            char[] numbersArray = string.Join("", inputNumbers).ToCharArray();
            
        }


    }
}
