using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    //Define a new class Student which is derived from Human and has a new field – grade.
    class Student : Human
    {
        private double grade;

        public Student (string first, string last, double grade)
            :base(first, last)
        {
            this.Grade = grade;
        }
        public double Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }
    }
}
