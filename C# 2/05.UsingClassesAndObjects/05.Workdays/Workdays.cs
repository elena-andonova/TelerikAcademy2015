using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workdays
{
    class Workdays
    {
        
    //Write a method that calculates the number of workdays between today and given date, passed as parameter.
    //Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
        static string[] HOLIDAYS = new string[]{
                                                     "02.03.2015",
                                                     "03.03.2015"
                                                };
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.Write("Give a date in the format dd.MM.yyyy: ");
            string input = Console.ReadLine(); // "05.03.2015";
            DateTime givenDate = DateTime.ParseExact(input, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int number = WorkingDays(today, givenDate);
            Console.WriteLine("Number of working days between today {0} and {1}: {2}", today.ToString("dd.MM.yyyy"), givenDate.ToString("dd.MM.yyyy"), number);
        }

        static int WorkingDays(DateTime today, DateTime given)
        {
            int counter = 0;
            int interval = 1;
            while (today.AddDays(interval) <= given)
            {
                today = today.AddDays(interval);
                string todayOfWeek = today.DayOfWeek.ToString();
                string todayStr = today.ToString("dd.MM.yyyy");
                bool isHoliday = HOLIDAYS.Contains(todayStr);

                if ((todayOfWeek != "Saturday") && (todayOfWeek != "Sunday") && (isHoliday == false))
                 {
                    counter++;
                 }
            }

            return counter;
        }
    }
}
