using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
//Problem 3. First before last
    //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    //Use LINQ query operators.
//Problem 4. Age range
//    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Problem 5. Order students
//    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//    Rewrite the same with LINQ.
//Problem 9. Student groups
    //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    //Create a List<Student> with sample students. Select only the students that are from group number 2.
    //Use LINQ query. Order the students by FirstName.
//Problem 10. Student groups extensions
    //Implement the previous using the same query expressed with extension methods.
    public static class StudentExtensions
    {
        public static void FirstBeforeLastName(this List<Student> students)
        {
            var firstBeforeLast =
                                from student in students
                                where student.FirstName.CompareTo(student.LastName) < 0
                                select student.FirstName + " " + student.LastName;

            foreach (string student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }
        }

        public static void AgeRange1824(this List<Student> students)
        {
            var ageRange1824 = 
                            from student in students
                            where student.Age >= 18 && student.Age <= 24
                            select student.FirstName + " " + student.LastName;

            foreach (string student in ageRange1824)
            {
                Console.WriteLine(student);
            }
        }

        public static void OrderByFirstThenByLastNameLAMBDA(this List<Student> students)
        {
            var firstThenLast = students
                                .OrderByDescending(student => student.FirstName)
                                .ThenByDescending(student => student.LastName)
                                .Select(student => student.FirstName + " " + student.LastName);
            foreach (string student in firstThenLast)
            {
                Console.WriteLine(student);
            }
        }

        public static void OrderByFirstThenByLastNameLINQ(this List<Student> students)
        {
            var firstThenLast = 
                                from student in students
                                orderby student.FirstName descending, student.LastName descending                                
                                select student.FirstName + " " + student.LastName;
            foreach (string student in firstThenLast)
            {
                Console.WriteLine(student);
            }
        }
        public static void SelectFromGroup2(this List<Student> students)
        {
            var selectedFromGroup2 =
                from student in students
                where student.GroupNumber == 2
                select student.FirstName + " " + student.LastName;

            foreach (string student in selectedFromGroup2)
            {
                Console.WriteLine(student);
            }
        }
        public static void OrderByFirstName(this List<Student> students)
        {
            var orderedByFirstName =
                            from student in students
                            orderby student.FirstName
                            select student.FirstName + " " + student.LastName;

            foreach (string student in orderedByFirstName)
            {
                Console.WriteLine(student);
            }
        }
    }
}
