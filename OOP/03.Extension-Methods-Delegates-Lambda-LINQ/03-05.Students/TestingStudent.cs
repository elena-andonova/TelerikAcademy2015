using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05.Students
{
    class TestingStudent
    {
        static void Main()
        {
            string divisor = new string('-', 77);
            List<Student> students = new List<Student> { };
            students.Add(new Student("Pesho", "Minkov", 17, "114206", "pminkov@gmail.com", "0283346278", 2));
            students.Add(new Student("Mariya", "Lilkova", 18, "114003", "mlilkova@abv.bg", "08874236541", 1));
            students.Add(new Student("Emilian", "Gargov", 25, "114012", "e.gargov@abv.bg", "08874200541", 2));
            students.Add(new Student("Georgi", "Stefanov", 19, "114106", "g_stefanov@mail.bg", "02874268712", 3));
            students[0].Marks = new List<int> { (int)Marks.Poor, (int)Marks.Excellent };
            students[1].Marks = new List<int> { (int)Marks.VeryGood, (int)Marks.Excellent };
            students[2].Marks = new List<int> { (int)Marks.Good, (int)Marks.Good, (int)Marks.Poor, (int)Marks.Poor };
            students[3].Marks = new List<int> { (int)Marks.Average, (int)Marks.Good };
            //Print(students);
            Console.WriteLine("--> Selecting students from group 2 with Lambda Expression:\n" + divisor);
            List<Student> studentsGroup2 = students.FindAll(x => (x.GroupNumber) == 2);
            Print(studentsGroup2);
            Console.WriteLine();
            Console.WriteLine("--> Selecting students from group 2 with LINQ:\n" + divisor);
            students.SelectFromGroup2();
            Console.WriteLine();
            Console.WriteLine("--> Ordering students by first name with LINQ:\n" + divisor);
            students.OrderByFirstName();
            Console.WriteLine();
            Console.WriteLine("--> Selecting students with first before last name alphabetically with LINQ:\n" + divisor);
            students.FirstBeforeLastName();
            Console.WriteLine();
            Console.WriteLine("--> Finding students with age between 18 and 24 with LINQ:\n" + divisor);
            students.AgeRange1824();
            Console.WriteLine();
            Console.WriteLine("--> Sorting students by first and then by last name in descending order with LAMBDA expressions:\n" + divisor);
            students.OrderByFirstThenByLastNameLAMBDA();
            Console.WriteLine();
            Console.WriteLine("--> Sorting students by first and then by last name in descending order with LINQ:\n" + divisor);
            students.OrderByFirstThenByLastNameLINQ();
            Console.WriteLine();
            Console.WriteLine("--> Extracting students with e-mails at abv.bg with LINQ:\n" + divisor);
            students.ExtractByEmail();
            Console.WriteLine();
            Console.WriteLine("--> Extracting students with phones in Sofia with LINQ:\n" + divisor);
            students.ExtractByPhone();
            Console.WriteLine();
            Console.WriteLine("--> Extracting students with at least one mark Excellent(6) with LINQ:\n" + divisor);
            students.ExtractByExcellentMark();
            Console.WriteLine();
            Console.WriteLine("--> Extracting students with exactly two marks Poor(2) with LINQ:\n" + divisor);
            students.ExtractByPoorMarks();
            Console.WriteLine();
            Console.WriteLine("--> Extracting student's marks enrolled in 2006 with LINQ:\n" + divisor);
            students.ExtractMarksForStudents06();
            Console.WriteLine();
            Console.WriteLine("--> Grouping students by group number with LINQ:\n" + divisor);
            students.GroupByGroupN();
            Console.WriteLine();
            Console.WriteLine("--> Grouping students by group number with LAMBDA:\n" + divisor);
            students.GroupByGroupNumberEXT();
            Console.WriteLine();
        }

        static void Print(List<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }
    }
}
