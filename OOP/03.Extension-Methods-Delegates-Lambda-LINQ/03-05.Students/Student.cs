using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
    //Problem 9. Student groups

    //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    //Create a List<Student> with sample students. Select only the students that are from group number 2.
    //Use LINQ query. Order the students by FirstName.

    public enum Marks
    {
        Poor = 2, Average = 3, Good = 4, VeryGood = 5, Excellent = 6
    }

    public class Student
    {
        private string firstName = "N/A";
        private string lastName = "N/A";
        private int age;
        private string facultyNumber = "N/A";
        private string tel = "N/A";
        private string email = "none@na.na";
        private List<int> marks = new List<int> { };
        private int groupNumber = 0;

        public Student(string firstName, string lastName, int age, string facultyNumber, string email, string tel, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<int> { };
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value;}
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The group number cannot be zero or negative!");
                }
                this.groupNumber = value; 
            }
        }

        public override string ToString()
        {
            return string.Format(@"
First name: {0}
Last name: {1}
FN: {2}
Group number: {3}
Tel: {4}",
         this.FirstName, this.LastName, this.FacultyNumber, this.GroupNumber, this.Tel);
        }
    }
}
