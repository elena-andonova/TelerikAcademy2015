using System;


namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(" {0, 3} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int SearchingPlatform(int platformSize, int row, int col, int[,] matrix)
        {
            int platformSum = 0;
            for (int platformRow = row; platformRow < row + platformSize; platformRow++)
            {
                for (int platformColumn = col; platformColumn < col + platformSize; platformColumn++)
                {
                    platformSum += matrix[platformRow, platformColumn];
                }
            }
            return platformSum;
        }

        static void PrintPlatform(int platformSize, int bestRow, int bestColumn, int[,] matrix)
        {
            for (int row = bestRow; row < bestRow + platformSize; row++)
            {
                for (int column = bestColumn; column < bestColumn + platformSize; column++)
                {
                    Console.Write(" {0, 3} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main()
        {
            //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements
            Console.Write("Enter the number of rows of the matrix N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns of the matrix M: ");
            int m = int.Parse(Console.ReadLine());
            if (n <= 0 || m <= 0)
            {
                Console.WriteLine("The input is incorrect! N and M must be > 0!");
                return;
            }
            int[,] matrix =new int[n, m];
                            //{ { 0, 2, 4, 0, 9, 5 }, 
                            //{ 7, 1, 3, 100, 2, 1 },
                            //{ 1, 3, 9, 100, 100, 6 },
                            //{ 4, 6, 7, 9, 1, 0 }};
            ReadMatrix(matrix);
            PrintMatrix(matrix);

            int platformSize = 3;
            if (platformSize > n || platformSize > m)
            {
                Console.WriteLine("The input is incorrect! The size of the platform must be < from N and M!");
            }
            int maximalSum = 0;
            int bestRow = 0;
            int bestColumn = 0;
            for (int row = 0; row < matrix.GetLength(0) - (platformSize - 1); row++)
            {
                 for (int column = 0; column < matrix.GetLength(1) - (platformSize - 1); column++)
                 {
                     int sumCandidate = SearchingPlatform(platformSize, row, column, matrix);
                     if (sumCandidate > maximalSum)
                     {
                         maximalSum = sumCandidate;
                         bestRow = row;
                         bestColumn = column;
                     }
                 }
            }
            
            PrintPlatform(platformSize, bestRow, bestColumn, matrix);
            Console.WriteLine("The maximal sum of the elements is: {0}", maximalSum);
        }
    }
}
