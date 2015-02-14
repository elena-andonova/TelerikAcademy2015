using System;


namespace _05.CalculateN_XN
{
    class CalculateN_XN
    {
        static void Main()
        {            
    //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    //Use only one loop. Print the result with 5 digits after the decimal point.
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter x: ");
            int x = int.Parse(Console.ReadLine());
            double fact = 1;
            double pow = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;                
                pow = pow * x;                
                sum += fact / pow ;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
