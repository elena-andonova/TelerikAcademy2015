using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
    //Problem 13. Extract students by marks
    //    Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
    //    Use LINQ.

    //Problem 14. Extract students with two marks

    //Write down a similar program that extracts the students with exactly two marks "2".
    //Use extension methods.

    //Problem 15. Extract marks
    //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
//    Problem 18. Grouped by GroupNumber

//    Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//    Use LINQ.

//Problem 19. Grouped by GroupName extensions

//    Rewrite the previous using extension methods.


    public static class AnonymousClass
    {
        public static void ExtractByExcellentMark(this List<Student> students)
        {
            var studentsWithExcellentMark =
                                        from student in students
                                        where student.Marks.Contains((int)Marks.Excellent)
                                        select new
                                        {
                                            FullName = student.FirstName + " " + student.LastName,
                                            Marks = student.Marks
                                        };

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.Marks));                
            }
        }

        public static void ExtractByPoorMarks(this List<Student> students)
        {
            var studentsWithPoorMarks =
                                        from student in students
                                        where student.Marks.FindAll(x => x == (int)Marks.Poor).Count == 2
                                        select new
                                        {
                                            FullName = student.FirstName + " " + student.LastName,
                                            Marks = student.Marks
                                        };

            foreach (var student in studentsWithPoorMarks)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.Marks));
            }
        }

        public static void ExtractMarksForStudents06(this List<Student> students)
        {
            var studentsFrom06 =
                                        from student in students
                                        where student.FacultyNumber.EndsWith("06") 
                                        select new
                                        {
                                            FullName = student.FirstName + " " + student.LastName,
                                            Marks = student.Marks
                                        };

            foreach (var student in studentsFrom06)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.Marks));
            }
        }
    }
}
