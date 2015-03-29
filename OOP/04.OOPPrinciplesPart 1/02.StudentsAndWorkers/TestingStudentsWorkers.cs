using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.
    class TestingStudentsWorkers
    {
        static void Main()
        {
            string div = new string('-', 77);
            List<Student> students = new List<Student>
                                    {
                                        new Student("Ivan", "Petrov", 3.45),
                                        new Student("Mary", "Doncheva", 4.20),
                                        new Student("Pesho", "Kanchev", 5.32),
                                        new Student("Filip", "Kirkov", 2.35),
                                        new Student("Plamen", "Gogov", 3.20),
                                        new Student("Diana", "Doncheva", 4.50),
                                        new Student("Ilian", "Jivkov", 5.60),
                                        new Student("Grigor", "Harmanliev", 6.00),
                                        new Student("Asen", "Lilkov", 2.00),
                                        new Student("Georgi", "Petrov", 6.00)
                                    };
            var sortedByGrade = students.OrderByDescending(st => st.Grade).ToList();
            Console.WriteLine("Students sorted by their grades in descending order:\n" + div);           
            sortedByGrade.ForEach(st => Console.WriteLine("{0} {1}, grade {2:F2}", st.FirstName, st.LastName, st.Grade));
            Console.WriteLine();

            List<Worker> workers = new List<Worker>
                                    {
                                        new Worker("Ivan", "Kanchev", 200, 8),
                                        new Worker("Mary", "Lilkova", 150, 6),
                                        new Worker("Toma", "Iovkov", 100, 5),
                                        new Worker("Robin", "Popov", 300, 8),
                                        new Worker("Evgeni", "Filipov", 280, 7),
                                        new Worker("Sara", "Evtimova", 90, 5),
                                        new Worker("Ivo", "Lolov", 90, 4),
                                        new Worker("Stamat", "Manolov", 250, 8),
                                        new Worker("Asen", "Romanov", 170, 4),
                                        new Worker("Pesho", "Georgiev", 250, 5)
                                    };
            var sortedByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
            Console.WriteLine("Workers sorted by money per hour in descending order:\n" + div);
            sortedByMoneyPerHour.ForEach(w => Console.WriteLine("{0} {1}, grade {2:F2}", w.FirstName, w.LastName, w.MoneyPerHour()));
            Console.WriteLine();

            List<Human> humans = new List<Human> { };
            for (int i = 0; i < 10; i++)
            {
                humans.Add(students[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                humans.Add(workers[i]);
            }
            var sortedByFirstLastName = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
            Console.WriteLine("Students and Workers sorted by first name and last name:\n" + div);
            sortedByFirstLastName.ForEach(h => Console.WriteLine("{0} {1}", h.FirstName, h.LastName));
            Console.WriteLine();
        }
    }
}
