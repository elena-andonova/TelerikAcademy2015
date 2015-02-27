using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _01.LeapYear
{
    class LeapYear
    {
        
    //Write a program that reads a year from the console and checks whether it is a leap one.
    //Use System.DateTime.

        static void Main()
        {
            string line = Console.ReadLine();
            int year = int.Parse(line);
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("Is the year {0} leap? : {1}", year, isLeap);
        }   
    }
}
