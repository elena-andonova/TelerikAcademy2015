using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            //Write a program that fills and prints a matrix of size (n, n) as shown below:
            Console.Write("For a matrix[n,n], enter a number for n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Not a valid number! n must be > 0!");
            }
            int[,] matrix = new int[n, n];
            Console.Write("Choose an option (a,b,c,d): ");
            string option = Console.ReadLine();
            int row = 0;
            int col = 0;
            int max = n * n;
            string direction = "";

            switch (option)
            {
                case "a":
                    {
                        direction = "down";
                        for (int number = 1; number <= max; number++)
                        {
                            if (direction == "down" && row > n - 1)
                            {
                                row = 0;
                                col++;
                            }

                            matrix[row, col] = number;
                            if (direction == "down")
                            {
                                row++;
                            }
                        }
                        for (row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0, 2} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    break;
                case "b":
                    {
                        direction = "down";
                        for (int number = 1; number <= max; number++)
                        {
                            if (direction == "down" && (row > n - 1))
                            {
                                direction = "up";
                                row--;
                                col++;
                            }
                            if (direction == "up" && row < 0)
                            {
                                direction = "down";
                                row++;
                                col++;
                            }

                            matrix[row, col] = number;
                            if (direction == "down")
                            {
                                row++;
                            }
                            if (direction == "up")
                            {
                                row--;
                            }
                        }
                        for (row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0, 2} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "c":
                    {
                        row = n - 1;
                        col = 0;
                        direction = "diagonal-down";
                        for (int i = 1; i <= max; i++)
                        {
                            matrix[row, col] = i;
                            if (direction == "diagonal-down")
                            {
                                row++;
                                col++;
                            }
                            if (direction == "diagonal-down" && (row > n - 1 && col <= n - 1))
                            {
                                row =  (n - 1) - col;
                                col = 0;
                            }
                            if (direction == "diagonal-down" && (row > n - 1 && col > n - 1))
                            {
                                row = 0;
                                col = 1;
                            }
                            if (direction == "diagonal-down" && (row <= n - 1 && col > n - 1))
                            {
                                col = (n - 1) - row + 2;
                                row = 0;
                            }
                        }
                        for (row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0, 2} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "d":
                    {
                        direction = "down";
                        for (int i = 1; i <= max; i++)
                        {
                            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                            {
                                direction = "right";
                                row--;
                                col++;
                            }
                            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                            {
                                direction = "up";
                                col--;
                                row--;
                            }
                            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                            {
                                direction = "down";
                                col++;
                                row++;
                            }
                            if (direction == "up" && row < 0 || matrix[row, col] != 0)
                            {
                                direction = "left";
                                row++;
                                col--;
                            }
                            matrix[row, col] = i;
                            if (direction == "down")
                            {
                                row++;
                            }
                            if (direction == "right")
                            {
                                col++;
                            }
                            if (direction == "up")
                            {
                                row--;
                            }
                            if (direction == "left")
                            {
                                col--;
                            }
                        }
                        for (row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0, 2} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Not a valid option!");
                    }
                    break;
            }
        }
    }
}
