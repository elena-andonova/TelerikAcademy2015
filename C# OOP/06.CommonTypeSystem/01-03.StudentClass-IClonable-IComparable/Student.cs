using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03.StudentClass_IClonable_IComparable
{
    /*Problem 1. Student class
    Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
    Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
     
     * Problem 2. IClonable
    Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

    * Problem 3. IComparable
    Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
     */

    class Student : ICloneable, IComparable<Student>
    {
        public enum Specialties { SSS, Arh, ViK, TS, Hidro, Goedesy, El, CompSciences, SoftEng, Biology }
        public enum Univercities { UACEG, SU, TU, TS }
        public enum Faculties { SF, AF, FMI, TF, HF, GF }

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string phone;
        private string email;
        private int course;
        private Specialties speciality;
        private Univercities university;
        private Faculties faculty;

        public Student(string fname, string mname, string lname, string ssn, string permAddr,
            string phone, int course, Specialties speciality, Univercities university, Faculties faculty)
        {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            this.SSN = ssn;
            this.PermanentAddress = permAddr;
            this.Phone = phone;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }
        public string SSN
        {
            get { return this.ssn; }
            set
            {
                this.ssn = value;
            }
        }
        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                this.permanentAddress = value;
            }
        }
        public string Phone
        {
            get { return this.phone; }
            set
            {
                this.phone = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (!value.Contains('@'))
                {
                    throw new ArgumentException("enter valid email");
                }
                this.email = value;
            }
        }
        public int Course
        {
            get { return this.course; }
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new ArgumentException("courses are between 1 and 8");
                }
                this.course = value;
            }
        }
        public Specialties Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }
        public Univercities University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public override string ToString()
        {
            string forPrint = string.Format("{0} {1} SSN: {2}", this.FirstName, this.LastName, this.SSN);
            return (forPrint);
        }
        public override int GetHashCode()
        {
            return (int.Parse(this.SSN) * 7 + this.SSN.Length * 13);
        }
        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1.Equals(st2));
        }
        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }
        public override bool Equals(object obj)
        {
            Student st2 = obj as Student;
            if (Object.Equals(st2, null))
            {
                return false;
            }
            if (Object.Equals(this.SSN, st2.SSN))
            {
                return true;
            }
            return false;
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.Phone, this.Course, this.Speciality, this.University, this.Faculty);
        }

        public int CompareTo(Student st2)
        {

            int fNameComp = this.FirstName.CompareTo(st2.FirstName);
            if (fNameComp != 0)
            {
                return fNameComp;
            }
            int mNameComp = this.MiddleName.CompareTo(st2.MiddleName);
            if (mNameComp != 0)
            {
                return mNameComp;
            }
            int lNameComp = this.LastName.CompareTo(st2.LastName);
            if (lNameComp != 0)
            {
                return lNameComp;
            }
            int ssnComp = (int.Parse(this.SSN)).CompareTo(int.Parse(st2.SSN));
            return ssnComp;
        }
    }
}

