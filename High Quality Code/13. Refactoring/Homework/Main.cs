using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixCrawler mycrawler = new MatrixCrawler(2, 2);
            mycrawler.FillInTheMatrix();
            Console.WriteLine(mycrawler.GetCellNumber(1, 1));
            mycrawler.PrintMatrix();
        }
    }
}
