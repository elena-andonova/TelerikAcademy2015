using System;
using System.Globalization;
using System.Threading;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            //    If the score is between 1 and 3, the program multiplies it by 10.
            //    If the score is between 4 and 6, the program multiplies it by 100.
            //    If the score is between 7 and 9, the program multiplies it by 1000.
            //    If the score is 0 or more than 9, the program prints “invalid score”.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter a score in the range [0;9]: ");
            int n = int.Parse(Console.ReadLine());
            int multiplier1 = 10;
            int multiplier2 = 100;
            int multiplier3 = 1000;
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The result is: {0}", n * multiplier1);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("The result is: {0}", n * multiplier2);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The result is: {0}", n * multiplier3);
                    break;
                default:
                    Console.WriteLine("Invalid score!");
                    break;
            }
        }
    }
}
