using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _07.Timer
{
    //    Problem 7. Timer
    //Using delegates write a class Timer that can execute certain method at each t seconds.
    public class Timer
    {
        private static System.Timers.Timer aTimer;
        public void Caller()
        {
            aTimer = new System.Timers.Timer(10000);

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = 2000;
            aTimer.Enabled = true;

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("executing certain method at each t seconds", e.SignalTime);
        }
    }
    class TimerTest
    {
        static void Main()
        {
            Timer myTimer = new Timer();
            myTimer.Caller();
        }
    }
}
