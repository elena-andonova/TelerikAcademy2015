using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        
    //Write a program that prints to the console which day of the week is today.
    //Use System.DateTime.

        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.DayOfWeek);
        }
    }
}
