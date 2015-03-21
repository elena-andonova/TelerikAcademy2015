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
            students.Add(new Student("Pesho", "Minkov", 17, 14203, "pminkov@gmail.com", "0883346278", 2));
            students.Add(new Student("Mariya", "Lilkova", 18, 14003, "mlilkova@abv.bg", "08874236541", 1));
            students.Add(new Student("Emilian", "Gargov", 25, 14012, "e.gargov@abv.bg", "08874200541", 2));
            students.Add(new Student("Georgi", "Stefanov", 19, 14101, "g_stefanov@mail.bg", "08874268712", 3));
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
