using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    //Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. 
    //Define the proper constructors and properties for this hierarchy.
    class Worker : Human
    {
        private const uint numberWorkDaysPerWeek = 5;
        private double weekSalary;
        private uint workHoursPerDay;

        public Worker(string first, string last, uint weekSal, uint hoursPerDay)
            :base(first, last)
        {
            this.WeekSalary = weekSal;
            this.WorkHoursPerDay = hoursPerDay;
        }
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public uint WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public double MoneyPerHour()
        {
            double result = this.WeekSalary / (this.WorkHoursPerDay * numberWorkDaysPerWeek);
            return result;
        }
    }
}
