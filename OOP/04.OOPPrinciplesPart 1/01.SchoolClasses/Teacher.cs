using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    class Teacher : Human
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
                         :base(firstName, lastName)
        {
            this.Disciplines = new List<Discipline> { };
        }
        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }
    }
}
