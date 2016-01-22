using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class MatrixCrawler
    {
        //const int[] DIR_X = { 1, 1, 1, 0, -1, -1, -1, 0 };
        //const int[] DIR_Y = { 1, 0, -1, -1, -1, 0, 1, 1 };
        int sizeX;
        int sizeY;
        int[,] theMatrix; 

        public MatrixCrawler(int sizeX, int sizeY){
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.theMatrix = new int[this.SizeX, this.SizeY];
        }
        public int SizeX
        {
            get { return this.sizeX; }
            private set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new ArgumentException("size [0,100]");
                }
                this.sizeX = value;
            }
        }
        public int SizeY
        {
            get { return this.sizeY; }
            private set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new ArgumentException("size [0,100]");
                }
                this.sizeY = value;
            }
        }

        public void FillInTheMatrix()
        {
            int numToAdd = 0;
            for (int i = 0; i < this.SizeX; i++)
            {
                for (int j = 0; j < this.SizeY; j++)
                {
                    Console.Write("enter you number: ");
                    numToAdd = int.Parse(Console.ReadLine());
                    this.theMatrix[i, j] = numToAdd;
                }
            }
        }
        public int GetCellNumber(int i,  int j)
        {
            if (i <= 0 || i > this.sizeX ||j <= 0 || j > this.sizeY)
            {
                throw new ArgumentException("the cell has to be in matrix borders");
            }
            return this.theMatrix[i - 1, j - 1];
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.SizeX; i++)
            {
                for (int j = 0; j < this.SizeY; j++)
                {
                    Console.Write("{0} ",this.theMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }

    }
}
