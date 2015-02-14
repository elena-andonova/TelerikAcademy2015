using System;


namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            
   // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());

            if ((1 <= n && n <= 20) == false)
            {
                Console.WriteLine("The condition (0 <= n <= 100) is not fulfilled!");
                return;
            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < row + n ; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
