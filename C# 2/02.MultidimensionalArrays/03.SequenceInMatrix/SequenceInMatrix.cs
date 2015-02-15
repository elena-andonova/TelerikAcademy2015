using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
    //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    //Write a program that finds the longest sequence of equal strings in the matrix.

            string[,] matrix = {{"ha", 	"fifi", "ho", "hi"},
                                {"fo", "ha", "hi", "xx"},
                                {"xxx", "ho", "ha", "xx"}};
            int diagCount = 1;
            int diagCountMax = 1;
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    for (int r2 = r + 1; r2 < matrix.GetLength(0); r2++)
                    {
                        for (int c2 = c + 1; c2 < matrix.GetLength(1); c2++)
                        {
                            if (matrix[r,c] == matrix[r2, c2])
                            {
                                diagCount++;
                            }
                            else
                            {
                                if (diagCountMax < diagCount)
                                {
                                    diagCountMax = diagCount;
                                }
                                diagCount = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(diagCountMax);
        }
    }
}
