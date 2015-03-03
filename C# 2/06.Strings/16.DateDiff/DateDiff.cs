using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
*/
namespace _16.DateDiff
{
    class DateDiff
    {
        static void Main(string[] args)
        {
            Console.Write("enter date one = ");
            string date1 = Console.ReadLine();
            Console.Write("enter date two = ");
            string date2 = Console.ReadLine();
            DateTime dt1 = DateTime.Parse(date1);
            DateTime dt2 = DateTime.Parse(date2);
            TimeSpan days = (dt1 - dt2);
            double NrOfDays = Math.Abs(days.TotalDays);
            Console.WriteLine(NrOfDays);
        }
    }
}
