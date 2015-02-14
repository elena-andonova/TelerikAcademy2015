using System;


namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {            
    //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    //Use the Euclidean algorithm (find it in Internet).

            Console.Write("Please enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter b: ");
            int b = int.Parse(Console.ReadLine());
            int max;
            int min;
            int quotient;
            int remainder;
            int GCD;

            if (a < b)
            {
                max = b;
                min = a;
            }
            else
            {
                max = a;
                min = b;
            }

            do
            {
                quotient = max / min;
                remainder = max % min;
                //Console.WriteLine(remainder);
                if (remainder == 0)
                {
                    GCD = min;
                    Console.WriteLine(GCD);
                } 
                max = min;
                //Console.WriteLine(max);
                min = remainder;
               // Console.WriteLine(min);       
            }
            while (remainder != 0);          
        }
    }
}
