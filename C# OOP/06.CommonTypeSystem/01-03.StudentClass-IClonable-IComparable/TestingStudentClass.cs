using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03.StudentClass_IClonable_IComparable
{
    class TestingStudentClass
    {
        static void Main()
        {
            Student st1 = new Student("Grigor", "Antonov", "Pipkov", "102506", "Pernik", "088339988523",
    2, Student.Specialties.SSS, Student.Univercities.UACEG, Student.Faculties.SF);
            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine(st1.ToString());

            Student st2 = new Student("Petya", "Radeva", "Molova", "130106", "Primorsko", "0883556688764",
                3, Student.Specialties.Hidro, Student.Univercities.UACEG, Student.Faculties.HF);

            Console.WriteLine(st1 == null);
            Console.WriteLine(st1 != st2);
            Console.WriteLine(st1 == st2);
            Console.WriteLine(st1.Equals(st2));

            Student st3 = (Student)st1.Clone();

            st1.FirstName = "Kircho";
            Console.WriteLine(st3.ToString());
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st1.CompareTo(st3));
            Console.WriteLine(st1.CompareTo(st1));
        }
    }
}
