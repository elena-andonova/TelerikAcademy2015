using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BitShiftMatrix
{
    class BitShiftMatrix
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, c];

            List<

            PrintingMatrix(matrix);



        }

        static void FillingMatrix(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            matrix[r - 1, 0] = 1;
            int max = r * c;

            int baseNum = 2;
            string direction = "";

            int row = r - 2;
            int col = 0;
            int pow = 1;
            for (int i = 1; i < max; i++)
            {
                matrix[row, col] = (int)Math.Pow(baseNum, pow);
                row++;
                col++;
                if ((row > r - 1 && col < c - 1))
                {
                    row = (r - 1) - col;
                    col = 0;
                    pow++;
                }
                if ((row > r - 1 && col == c - 1))
                {
                    row = 0;
                    col = 1;
                    pow++;
                }

                if ((row > r - 1 && col > c - 1))
                {
                    row = 0;
                    col = 2;
                    pow++;
                }
                if ((row <= r - 1 && col > c - 1))
                {
                    col = (c - 1) - row + 2;
                    row = 0;
                    pow++;
                }
            }
        }
        static void PrintingMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
