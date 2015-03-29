using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Student : Human
    {
        private uint studentNumber;

        public Student(string firstName, string lastName, uint number)
            :base(firstName, lastName)
        {
            this.StudentNumber = number;
        }

        public uint StudentNumber
        {
            get { return this.studentNumber; }
            set { this.studentNumber = value; }
        }
    }
}
