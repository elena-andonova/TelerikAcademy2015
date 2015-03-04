using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
*/
namespace _05.MaxAreaNum
{
    class MaxAreaNum
    {
        static void Main(string[] args)
        {
            string fileLocation = @"D:\Telerik Academy\Homeworks\C# 2\textFiles\Matrix.txt";
            StreamReader reader = new StreamReader(fileLocation);
            string matrixLine = "";
            using (reader)
            {
                matrixLine = reader.ReadToEnd();
            }

            string[] matrixLines = matrixLine.Split('\n');
            Console.WriteLine(matrixLines[1]);
            int size = int.Parse(matrixLines[0]);

            string[] matrixElements = new string[size * size];


            
            Console.WriteLine(size);
            //int[,] matrix = new int[size, size];
            //matrixArr = matrixLine.Split(' ');
            //Console.WriteLine(matrixArr[0]);

            //for (int r = 0; r < size; r++)
            //{
            //    string[] oneRow = matrixArr[r + 1].Split(' ');
            //    for (int c = 0; c < size; c++)
            //    {
            //        matrix[r, c] = int.Parse(oneRow[r]);
            //    }
            //}

            //PrintMatrix(matrix);

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
    }
}
