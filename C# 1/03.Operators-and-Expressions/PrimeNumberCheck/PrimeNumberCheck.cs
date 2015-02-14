using System;


namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int number = 97;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool prime = true;
            if (number > 1)
            {
                while (prime && (divider <= maxDivider))
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
                Console.WriteLine("The number {0} is Prime? : {1} ",
                                    number, prime);
            }
            else
            {
                prime = false;
                Console.WriteLine("The number {0} is Prime? : {1} ",
                                    number, prime);
            }
        }
    }
}
