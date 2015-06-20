using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class SchoolClass
    {
        private string classNumber;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string number)
        {
            this.ClassNumber = number;
            this.Students = new List<Student> { };
            this.Teachers = new List<Teacher> { };
        }

        public string ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

    }
}
