using System;
using System.Globalization;
using System.Threading;


namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {            
            //A beer time is after 1:00 PM and before 3:00 AM.
            //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
            //a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
            //according to the definition above or invalid time if the time cannot be parsed. 
            //        Note: You may need to learn how to parse dates and times.

            Console.Write("Please enter a time in the format \"hh:mm tt\"(e.g: 5:00 AM): ");
            string line = Console.ReadLine();
            DateTime time = new DateTime();
            bool invalidInput = DateTime.TryParseExact(line, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out time);
            if (invalidInput == true)
            {
                time = DateTime.ParseExact(line, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                DateTime startsAfter = DateTime.ParseExact("1:00 PM", "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                DateTime endsBefore = DateTime.ParseExact("3:00 AM", "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                if ((time >= startsAfter) && (time >= endsBefore))
                {
                    Console.WriteLine("beer time");
                }
                else if (time <= endsBefore)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            } 
        }
    }
}
